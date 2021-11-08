using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Teoria_Grafurilor
{
    public partial class frmEvalPrac : Form
    {
        public frmEvalPrac()
        {
            InitializeComponent();
        }

        bool orientat = false;
        Color color = Color.White;
        string[] cerinte = { "graf neorientat conex", "arbore", "graf neorientat cu doua componente conexe", "graf neorientat care sa contina cel putin un ciclu", "graf neorientat eulerian", "graf tare conex", "graf cu doua componente tare conexe", "graf neorientat complet", "graf neorientat cu 12 noduri , 11 muchii si numar maxim de componente conexe", "arbore reprezentat prin urmatorul vector de tati: {1, 3, 3, -1, 1, 2, 2, 2, 3, 0, 4}, unde indexarea incepe de la 0 si nodul 3 este radacina" };

        int startIndex; // 0, 1
        int nrCerinte = 10;
        string cerintaCrt = "";
        int indexCerintaCrt = 0;

        public class Node
        {
            public Point location;
            public Color color;
            public int index;
            public Node(int X, int Y)
            {
                location = new Point(X, Y);
            }
        }

        public class Graph
        {
            public int node_nextIndex;
            public int edge_count;
            public int node_count;
            public Node[] nodes = new Node[1000];
            public Edge[] edges = new Edge[1000];
            public List<int>[] list = new List<int>[1000];
        }

        Graph G = new Graph();

        public class Edge
        {
            public Node x, y;
            public Color color;
            public Edge(Node a, Node b, Color clr)
            {
                x = a; y = b; color = clr;
            }
        }

        public void drawEdge(Node n1, Node n2, Graphics g, Color clr)
        {
            Pen pen = new Pen(clr, 3);
            double vx = (n1.location.X - n2.location.X);
            double vy = (n1.location.Y - n2.location.Y);
            double ux = (vx) / (Math.Sqrt(vx * vx + vy * vy));
            double uy = (vy) / (Math.Sqrt(vx * vx + vy * vy));
            float xf1 = (float)(n1.location.X - 25 * ux);
            float xf2 = (float)(n2.location.X + 25 * ux);
            float yf1 = (float)(n1.location.Y - 25 * uy);
            float yf2 = (float)(n2.location.Y + 25 * uy);
            g.DrawLine(pen, xf1, yf1, xf2, yf2);

        }

        public void drawArrow(Node n1, Node n2, Graphics g, Color color)
        {
            Pen whitePen = new Pen(Color.White, 3);
            double vx = (n2.location.X - n1.location.X);
            double vy = (n2.location.Y - n1.location.Y);
            double ux = (vx) / (Math.Sqrt(vx * vx + vy * vy));
            double uy = (vy) / (Math.Sqrt(vx * vx + vy * vy));
            float xf1 = (float)(n1.location.X + 25 * ux);
            float xf2 = (float)(n2.location.X - 25 * ux);
            float yf1 = (float)(n1.location.Y + 25 * uy);
            float yf2 = (float)(n2.location.Y - 25 * uy);

            double theta = Math.PI / 6;
            double rvx1 = -vx * Math.Cos(theta) + vy * Math.Sin(theta);
            double rvy1 = -vx * Math.Sin(theta) - vy * Math.Cos(theta);

            double rv1len = Math.Sqrt(rvx1 * rvx1 + rvy1 * rvy1);

            double rvx2 = -vx * Math.Cos(-theta) + vy * Math.Sin(-theta);
            double rvy2 = -vx * Math.Sin(-theta) - vy * Math.Cos(-theta);

            double rv2len = Math.Sqrt(rvx2 * rvx2 + rvy2 * rvy2);

            g.DrawLine(new Pen(color, 3), new Point((int)xf2, (int)yf2), new Point((int)(xf2 + rvx1 / rv1len * 25), (int)(yf2 + rvy1 / rv1len * 25)));
            g.DrawLine(new Pen(color, 3), new Point((int)xf2, (int)yf2), new Point((int)(xf2 + rvx2 / rv2len * 25), (int)(yf2 + rvy2 / rv2len * 25)));

            // g.DrawLine(whitePen, xf2, yf2, (float)rx1, (float)ry1);
        }

        public void drawCursorNodeLine(Point p1, Node n, Graphics g)
        {
            Pen whitePen = new Pen(Color.White, 3);
            double vx = (p1.X - n.location.X);
            double vy = (p1.Y - n.location.Y);
            double ux = (vx) / (Math.Sqrt(vx * vx + vy * vy));
            double uy = (vy) / (Math.Sqrt(vx * vx + vy * vy));
            float xf2 = (float)(n.location.X + 25 * ux);
            float yf2 = (float)(n.location.Y + 25 * uy);
            g.DrawLine(whitePen, p1.X, p1.Y, xf2, yf2);
        }


        public bool checkIfNode(Node n)
        {
            for (int i = 0; i < G.node_nextIndex; i++)
                if ((Math.Sqrt(((G.nodes[i].location.X - n.location.X) * (G.nodes[i].location.X - n.location.X)) + ((G.nodes[i].location.Y - n.location.Y) * (G.nodes[i].location.Y - n.location.Y)))) < 25)
                    return true;
            return false;
        }

        private void frmEval2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for (int i = 0; i < G.node_nextIndex; i++)
            {
                if (G.nodes[i] == null)
                    continue;
                G.nodes[i].index = i;
                if (i < 10)
                {
                    Pen pen = new Pen(G.nodes[i].color, 3);
                    Rectangle rect = new Rectangle(G.nodes[i].location.X - 25, G.nodes[i].location.Y - 25, 50, 50);
                    e.Graphics.DrawString(i.ToString(), new Font("Arial", 16, FontStyle.Bold), new SolidBrush(G.nodes[i].color), new Rectangle(G.nodes[i].location.X - 10, G.nodes[i].location.Y - 10, 50, 50));
                    e.Graphics.DrawEllipse(pen, rect);
                }
                else
                {
                    Pen pen = new Pen(G.nodes[i].color, 3);
                    Rectangle rect = new Rectangle(G.nodes[i].location.X - 25, G.nodes[i].location.Y - 25, 50, 50);
                    e.Graphics.DrawString(i.ToString(), new Font("Arial", 16, FontStyle.Bold), new SolidBrush(G.nodes[i].color), new Rectangle(G.nodes[i].location.X - 16, G.nodes[i].location.Y - 10, 50, 50));
                    e.Graphics.DrawEllipse(pen, rect);
                }

            }
            for (int i = 0; i < G.edge_count; i++)
            {
                if (G.edges[i] == null)
                    continue;
                drawEdge(G.edges[i].x, G.edges[i].y, e.Graphics, G.edges[i].color);
                if (orientat)
                {
                    drawArrow(G.edges[i].x, G.edges[i].y, e.Graphics, G.edges[i].color);
                }
            }
            if (selectedNode_ != null)
            {
                drawCursorNodeLine(this.PointToClient(Cursor.Position), selectedNode_, e.Graphics);
                Invalidate();
            }
        }

        private void frmEval2_Load(object sender, EventArgs e)
        {
            cerintaCrt = cerinte[indexCerintaCrt];
            for (int i = 0; i < 1000; i++)
            {
                G.list[i] = new List<int>();
            }
            lblCerinta.Text = "Desenati un " + cerintaCrt;
        }

        public double distance(Point a, Point b)
        {
            return Math.Sqrt(((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y)));
        }

        Node selectedNode_;

        void removeNode(Node n)
        {
            G.node_count--;
            for (int i = 0; i < G.node_nextIndex; i++)
            {
                if (G.nodes[i] != null)
                    G.list[G.nodes[i].index].Remove(n.index);
                if (G.nodes[i] == n)
                {
                    G.nodes[i] = null;
                }
            }

            for (int i = 0; i < G.edge_count; i++)
            {
                if (G.edges[i].x == n || G.edges[i].y == n)
                {
                    for (int j = i; j < G.edge_count; j++)
                    {
                        G.edges[j] = G.edges[j + 1];
                    }
                    G.edge_count--;
                    i--;
                }
            }

        }

        void removeEdgeAt(int i)
        {
            G.list[G.edges[i].x.index].Remove(G.edges[i].y.index);
            G.list[G.edges[i].y.index].Remove(G.edges[i].x.index);
            for (int j = i; j < G.edge_count; j++)
            {
                G.edges[j] = G.edges[j + 1];
            }
            G.edge_count--;
        }


        private void frmEval2_MouseClick(object sender, MouseEventArgs e)
        {
            Node n = new Node(e.X, e.Y);
            n.color = color;
            Node targetNode;
            bool overlap = false;
            //MessageBox.Show(e.X.ToString() + " " + MousePosition.X.ToString() + " " + e.Y.ToString() + " " + MousePosition.Y.ToString());
            for (int i = 0; i < G.node_nextIndex; i++)
            {
                if (G.nodes[i] != null && distance(G.nodes[i].location, new Point(e.X, e.Y)) < 50)
                {
                    overlap = true;
                    break;
                }
            }
            for (int i = 0; i < G.node_nextIndex; i++)
            {
                if (G.nodes[i] != null && distance(G.nodes[i].location, new Point(e.X, e.Y)) < 25)
                {
                    if (e.Button == MouseButtons.Middle)
                    {
                        G.nodes[i].color = color;
                    }
                    else
                    {
                        if (selectedNode_ != null)
                        {
                            targetNode = G.nodes[i];
                            if (!G.list[selectedNode_.index].Contains(targetNode.index) && selectedNode_.index != targetNode.index)
                            {
                                G.list[selectedNode_.index].Add(targetNode.index);
                            }
                            if (!orientat)
                            {
                                if (!G.list[targetNode.index].Contains(selectedNode_.index) && selectedNode_.index != targetNode.index)
                                {
                                    G.list[targetNode.index].Add(selectedNode_.index);
                                }
                            }
                            G.edges[G.edge_count++] = new Edge(selectedNode_, targetNode, Color.White);
                            selectedNode_ = null;
                        }
                        else
                        {
                            selectedNode_ = G.nodes[i];
                            /* label2.Text = "";
                             foreach (int l in G.list[selectedNode_.index])
                             {
                                 label2.Text += (" " + l.ToString());
                             }*/
                            if (e.Button == MouseButtons.Right)
                            {
                                removeNode(selectedNode_);
                                selectedNode_ = null;
                                Invalidate();
                                return;
                            }

                        }
                    }
                }



            }

            for (int i = 0; i < G.edge_count; i++)
            {
                int y = G.edges[i].x.location.Y;
                int y0 = G.edges[i].y.location.Y;
                int x = G.edges[i].x.location.X;
                int x0 = G.edges[i].y.location.X;
                double md = (double)(y - y0) / (x - x0);
                double d = Math.Abs(md * e.X - e.Y + y0 - md * x0) / Math.Sqrt(md * md + 1);

                int prod1 = (e.X - x0) * (x - x0) + (e.Y - y0) * (y - y0);
                int prod2 = (e.X - x) * (x0 - x) + (e.Y - y) * (y0 - y);

                if (d < 10 && prod1 > 0 && prod2 > 0)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        removeEdgeAt(i);
                        Invalidate();
                        return;
                    }
                    else if (e.Button == MouseButtons.Middle && !overlap)
                    {
                        G.edges[i].color = color;
                    }
                }

            }

            if (!overlap)
            {
                if (selectedNode_ == null && e.Button == MouseButtons.Left)
                {
                    selectedNode_ = null;
                    if (G.node_count == 0)
                    {
                        G.node_nextIndex = startIndex;
                    }
                    G.node_count++;
                    G.nodes[G.node_nextIndex] = n;
                    G.nodes[G.node_nextIndex].color = Color.White;
                    G.list[G.node_nextIndex] = new List<int>();
                    G.node_nextIndex++;
                }
                else
                {
                    selectedNode_ = null;
                }
            }
            Invalidate();
        }

        private void frmEval2_MouseHover(object sender, EventArgs e)
        {

        }

        Node movedNode;
        Point originNodeLocation;
        int movedIndex;

        private void frmEval2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                for (int i = 0; i < G.node_nextIndex; i++)
                {
                    if (G.nodes[i] != null && distance(G.nodes[i].location, new Point(e.X, e.Y)) < 25)
                    {
                        movedNode = G.nodes[i];
                        originNodeLocation = G.nodes[i].location;
                        movedIndex = i;
                        break;
                    }
                }
        }

        private void frmEval2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && movedNode != null)
            {
                if (G.nodes[movedIndex] != null && movedNode != null && movedIndex != -1 && distance(originNodeLocation, G.nodes[movedIndex].location) >= 5)
                {
                    selectedNode_ = null;
                }
                G.nodes[movedIndex].location.X = e.X;
                G.nodes[movedIndex].location.Y = e.Y;
                Invalidate();
            }


        }

        private void frmEval2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (movedNode != null && movedIndex != -1 && G.nodes[movedIndex] != null && distance(originNodeLocation, G.nodes[movedIndex].location) >= 5)
                {
                    selectedNode_ = null;
                }
                movedIndex = -1;
                movedNode = null;
            }
        }

        private void frmEval2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.evaluarePractica = null;
        }

        private void btnOrientat_Click(object sender, EventArgs e)
        {
            orientat = true;
            for (int i = 0; i < 1000; i++)
            {
                G.list[i] = new List<int>();
            }

            for (int i = 0; i < G.edge_count; i++)
            {
                Node a = G.edges[i].x;
                Node b = G.edges[i].y;
                if (!G.list[a.index].Contains(b.index) && a.index != b.index)
                {
                    G.list[a.index].Add(b.index);
                }
            }
            Invalidate();
        }

        private void btnNeorientat_Click(object sender, EventArgs e)
        {
            orientat = false;
            for (int i = 0; i < 1000; i++)
            {
                G.list[i] = new List<int>();
            }

            for (int i = 0; i < G.edge_count; i++)
            {
                Node a = G.edges[i].x;
                Node b = G.edges[i].y;
                if (!G.list[a.index].Contains(b.index) && a.index != b.index)
                {
                    G.list[a.index].Add(b.index);
                }
                if (orientat == false)
                {
                    if (!G.list[b.index].Contains(a.index) && b.index != a.index)
                    {
                        G.list[b.index].Add(a.index);
                    }
                }
            }
            Invalidate();
        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        bool[] viz = new bool[1000];
        int[] tt = new int[1000];

        void DFS(int x)
        {
            viz[x] = true;
            foreach (int v in G.list[x])
            {
                if (!viz[v])
                {
                    DFS(v);
                }
            }
        }


        List<int> po = new List<int>();
        void DFSKosaraju(int x)
        {
            viz[x] = true;
            foreach (int v in G.list[x])
            {
                if (!viz[v])
                {
                    DFSKosaraju(v);
                }
            }
            po.Add(x);
        }

        void DFSKosarajuT(int x)
        {
            viz[x] = false;
            foreach (int v in listGT[x])
            {
                if (viz[v])
                {
                    DFSKosarajuT(v);
                }
            }
        }

        void DFSTree(int x, int father)
        {
            viz[x] = true;
            tt[x] = father;
            foreach (int v in G.list[x])
            {
                if (!viz[v])
                {
                    DFSTree(v, x);
                }
            }
        }

        bool contineCiclu_;
        void detectCycle(int x, int father)
        {
            viz[x] = true;
            tt[x] = father;
            if (G.list[0] != null)
                foreach (int v in G.list[x])
                {
                    if (!viz[v])
                    {
                        DFSTree(v, x);
                    }
                    else
                    {
                        if (v != father)
                        {
                            contineCiclu_ = true;
                        }
                    }
                }
        }

        List<int>[] listGT = new List<int>[1000];

        int scor = 0;

        void endCheck(bool corect)
        {
            scor += (corect ? 1 : 0);
            if (indexCerintaCrt == nrCerinte - 1)
            {
                MessageBox.Show("Felicitări, ați obținut " + scor.ToString() + " puncte!");
            }
            btnVerifica.Enabled = false;
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        { //"graf hamiltonian", "graf tare conex" 
            if(G.node_count == 0 )
            {
                MessageBox.Show("Incorect");
                endCheck(false);
                return;
            }
            bool corect = false;
            if (cerintaCrt == "graf neorientat conex")
            {
                for (int i = 0; i < 1000; i++)
                {
                    viz[i] = false;
                }

                int compConexe = 0;
                for (int i = 0; i < G.node_nextIndex; i++)
                {
                    if (G.nodes[i] != null && !viz[G.nodes[i].index])
                    {
                        DFS(G.nodes[i].index);
                        compConexe++;
                        if (compConexe > 1)
                        {
                            MessageBox.Show("Incorect");
                            endCheck(corect);
                            return;
                        }
                    }
                }
                if (compConexe == 1 && !orientat)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("incorect");
                }
                endCheck(corect);
                return;
            }
            else if (cerintaCrt == "graf neorientat cu doua componente conexe")
            {
                for (int i = 0; i < 1000; i++)
                {
                    viz[i] = false;
                }

                int compConexe = 0;
                for (int i = 0; i < G.node_nextIndex; i++)
                {
                    if (G.nodes[i] != null && !viz[G.nodes[i].index])
                    {
                        DFS(G.nodes[i].index);
                        compConexe++;
                        if (compConexe > 2)
                        {
                            MessageBox.Show("Incorect");
                            endCheck(corect);
                            return;
                        }
                    }
                }
                if (compConexe == 2 && !orientat)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("Incorect");
                }
                endCheck(corect);
                return;
            }
            else if (cerintaCrt == "arbore")
            {
                for (int i = 0; i < 1000; i++)
                {
                    viz[i] = false;
                }
                if (G.edge_count != G.node_count - 1)
                {
                    MessageBox.Show("Incorect");
                    endCheck(corect);
                    return;
                }

                int compConexe = 0;
                for (int i = 0; i < G.node_nextIndex; i++)
                {
                    if (G.nodes[i] != null && !viz[G.nodes[i].index])
                    {
                        DFS(G.nodes[i].index);
                        compConexe++;
                        if (compConexe > 1)
                        {
                            MessageBox.Show("Incorect");
                            endCheck(corect);
                            return;
                        }
                    }
                }
                if (compConexe == 1)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("Incorect");
                }
                endCheck(corect);
                return;

            }
            else if (cerintaCrt == "graf neorientat eulerian")
            {
                for (int i = 0; i < G.node_count; i++)
                {
                    if (G.nodes[i] != null && G.list[G.nodes[i].index].Count() % 2 == 1)
                    {
                        MessageBox.Show("Incorect");
                        endCheck(corect);
                        return;
                    }
                }
                MessageBox.Show("Corect");
                corect = true;
            }
            else if (cerintaCrt == "graf tare conex")
            {
                for (int i = 0; i < 1000; i++)
                {
                    viz[i] = false;
                    listGT[i] = new List<int>();
                }

                po = new List<int>();
                for (int i = 0; i < G.edge_count; i++)
                {
                    Node a = G.edges[i].x;
                    Node b = G.edges[i].y;
                    if (!listGT[b.index].Contains(a.index) && a.index != b.index)
                    {
                        listGT[b.index].Add(a.index);
                    }
                }

                for (int i = 0; i < G.node_nextIndex; i++)
                {
                    if (G.nodes[i] != null && !viz[G.nodes[i].index])
                    {
                        DFSKosaraju(G.nodes[i].index);
                    }
                }

                int comp = 0;
                for (int i = po.Count() - 1; i >= 0; i--)
                {
                    if (viz[po[i]])
                    {
                        comp++;
                        DFSKosarajuT(po[i]);
                    }
                }

                if (comp == 1)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("Incorect. Graful are " + comp.ToString() + " componente tare conexe");
                }

            }
            else if (cerintaCrt == "graf cu doua componente tare conexe")
            {
                for (int i = 0; i < 1000; i++)
                {
                    viz[i] = false;
                    listGT[i] = new List<int>();
                }

                po = new List<int>();
                for (int i = 0; i < G.edge_count; i++)
                {
                    Node a = G.edges[i].x;
                    Node b = G.edges[i].y;
                    if (!listGT[b.index].Contains(a.index) && a.index != b.index)
                    {
                        listGT[b.index].Add(a.index);
                    }
                }

                for (int i = 0; i < G.node_nextIndex; i++)
                {
                    if (G.nodes[i] != null && !viz[G.nodes[i].index])
                    {
                        DFSKosaraju(G.nodes[i].index);
                    }
                }

                int comp = 0;
                for (int i = po.Count() - 1; i >= 0; i--)
                {
                    if (viz[po[i]])
                    {
                        comp++;
                        DFSKosarajuT(po[i]);
                    }
                }

                if (!orientat)
                {
                    MessageBox.Show("Graful nu este orientat!");
                    endCheck(corect);
                    return;

                }
                if (comp == 2)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("Incorect. Graful are " + comp.ToString() + " componente tare conexe");
                }
            }
            else if (cerintaCrt == "graf neorientat complet")
            {
                if (orientat)
                {
                    MessageBox.Show("Graful este orientat");
                    endCheck(corect);
                    return;
                }
                if (G.edge_count == G.node_count * (G.node_count - 1) / 2)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("Incorect");
                }
            }
            else if (cerintaCrt == "graf neorientat cu 12 noduri , 11 muchii si numar maxim de componente conexe")
            {
                for (int i = 0; i < 1000; i++)
                {
                    viz[i] = false;
                }

                int compConexe = 0;
                for (int i = 0; i < G.node_nextIndex; i++)
                {
                    if (G.nodes[i] != null && !viz[G.nodes[i].index])
                    {
                        DFS(G.nodes[i].index);
                        compConexe++;
                    }
                }
                if (compConexe == 7 && !orientat && G.edge_count == 11)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("Incorect");
                }
                endCheck(corect);
                return;
            }
            else if (cerintaCrt == "arbore reprezentat prin urmatorul vector de tati: {1, 3, 3, -1, 1, 2, 2, 2, 3, 0, 4}, unde indexarea incepe de la 0 si nodul 3 este radacina")
            {
                if (G.node_count != 11)
                {
                    MessageBox.Show("Incorect");
                    endCheck(corect);
                    return;
                }

                for (int i = 0; i < 10; i++)
                {
                    if (G.nodes[i] == null)
                    {
                        MessageBox.Show("Incorect");
                        endCheck(corect);
                        return;
                    }
                }

                for (int i = 0; i < 1000; i++)
                {
                    tt[i] = i;
                    viz[i] = false;
                }
                tt[3] = -1;
                DFSTree(3, -1);
                if (tt[0] == 1 &&
                    tt[1] == 3 &&
                    tt[2] == 3 &&
                    tt[3] == -1 &&
                    tt[4] == 1 &&
                    tt[5] == 2 &&
                    tt[6] == 2 &&
                    tt[7] == 2 &&
                    tt[8] == 3 &&
                    tt[9] == 0 &&
                    tt[10] == 4)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("Incorect");
                }
            }
            else if (cerintaCrt == "graf neorientat care sa contina cel putin un ciclu")
            {

                if (orientat)
                {
                    MessageBox.Show("Incorect");
                    endCheck(corect);
                    return;
                }

                for (int i = 0; i < 1000; i++)
                {
                    tt[i] = i;
                    viz[i] = false;
                }

                contineCiclu_ = false;

                detectCycle(0, -1);
                if (contineCiclu_)
                {
                    MessageBox.Show("Corect");
                    corect = true;
                }
                else
                {
                    MessageBox.Show("Incorect");
                }

            }
            endCheck(corect);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnContinua_Click(object sender, EventArgs e)
        {
            if (btnVerifica.Enabled == true && MessageBox.Show("Atenție! Nu vă veți putea întoarce la această cerință. Dacă nu ați apăsat butonul Verifica, nu veți primi niciun punct indiferent de graful desenat. Sigur doriți să continuați?", "Atenție", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            indexCerintaCrt++;
            /*if (indexCerintaCrt > nrCerinte - 1)
            {
                //indexCerintaCrt = 0; 

            }*/

            if (indexCerintaCrt == nrCerinte - 1)
            {
                btnContinua.Enabled = false;
            }

            cerintaCrt = cerinte[indexCerintaCrt];
            G = new Graph();
            selectedNode_ = null;
            lblCerinta.Text = "Deseneaza un " + cerintaCrt;
            btnVerifica.Enabled = true;
            Invalidate();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            G = new Graph();
            Invalidate();
        }

        public static frmHelp help;
        private void pbHelp_Click(object sender, EventArgs e)
        {
            if (help == null)
            {
                help = new frmHelp();
                help.Show();
            }
        }
    }
}

