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
    public partial class frmDraw : Form
    {
        public frmDraw()
        {
            InitializeComponent();
        }

        bool orientat = false;
        Color color = Color.White;

        public class Node
        {
            public Point location;
            public Color color;
            public Node(int X, int Y)
            {
                location = new Point(X, Y);
            }
        }

        public class Graph
        {
            public int node_count;
            public int edge_count;
            public Node[] nodes = new Node[1000];
            public Edge[] edges = new Edge[1000];
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
            for (int i = 0; i < G.node_count; i++)
                if ((Math.Sqrt(((G.nodes[i].location.X - n.location.X) * (G.nodes[i].location.X - n.location.X)) + ((G.nodes[i].location.Y - n.location.Y) * (G.nodes[i].location.Y - n.location.Y)))) < 25)
                    return true;
            return false;
        }

        private void frmDraw_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for (int i = 0; i < G.node_count; i++)
            {
                if (G.nodes[i] == null)
                    continue;

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

        private void frmDraw_Load(object sender, EventArgs e)
        {

        }

        public double distance(Point a, Point b)
        {
            return Math.Sqrt(((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y)));
        }

        Node selectedNode_;

        void removeNode(Node n)
        {
            for (int i = 0; i < G.node_count; i++)
            {
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
            for (int j = i; j < G.edge_count; j++)
            {
                G.edges[j] = G.edges[j + 1];
            }
            G.edge_count--;
        }


        private void frmDraw_MouseClick(object sender, MouseEventArgs e)
        {
            Node n = new Node(e.X, e.Y);
            n.color = color;
            Node targetNode;
            bool overlap = false;
            //MessageBox.Show(e.X.ToString() + " " + MousePosition.X.ToString() + " " + e.Y.ToString() + " " + MousePosition.Y.ToString());
            for (int i = 0; i < G.node_count; i++)
            {
                if (G.nodes[i] != null && distance(G.nodes[i].location, new Point(e.X, e.Y)) < 50)
                {
                    overlap = true;
                    break;
                }
            }
            for (int i = 0; i < G.node_count; i++)
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
                            G.edges[G.edge_count++] = new Edge(selectedNode_, targetNode, Color.White);
                            selectedNode_ = null;
                        }
                        else
                        {
                            selectedNode_ = G.nodes[i];
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

                if (d < 10  && prod1 > 0 && prod2 > 0)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        removeEdgeAt(i);
                        Invalidate();
                        return;
                    }
                    else if(e.Button == MouseButtons.Middle && !overlap)
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
                    G.nodes[G.node_count] = n;
                    G.nodes[G.node_count].color = Color.White;
                    G.node_count++;
                }
                else
                {
                    selectedNode_ = null;
                }

            }



            Invalidate();
        }

        private void frmDraw_MouseHover(object sender, EventArgs e)
        {

        }

        Node movedNode;
        Point originNodeLocation;
        int movedIndex;

        private void frmDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                for (int i = 0; i < G.node_count; i++)
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

        private void frmDraw_MouseMove(object sender, MouseEventArgs e)
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

        private void frmDraw_MouseUp(object sender, MouseEventArgs e)
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

        private void frmDraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.draw = null;
        }

        private void btnOrientat_Click(object sender, EventArgs e)
        {
            orientat = true;
            Invalidate();
        }

        private void btnNeorientat_Click(object sender, EventArgs e)
        {
            orientat = false;
            Invalidate();
        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        public static frmHelp help;

        private void pbHelp_Click(object sender, EventArgs e)
        {
            if(help == null)
            {
                help = new frmHelp();
                help.Show();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            G = new Graph();
            Invalidate();
        }
    }
}
