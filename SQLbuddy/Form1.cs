using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLbuddy
{
    public partial class Form1 : Form
    {
        public bool rowClicked = false;
        public bool headerClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertSQL_Click(object sender, EventArgs e)
        {

            rtfOutputSQL.Text = "";
            int lineLimit = 10;
            string currentLine = "";
            string beginning, end, middle;
            string converted = "";
            if (rowClicked) { beginning = "VALUES ('"; }
            else { beginning = "IN ('"; }

            middle = "','";
            end = "')";


            converted = beginning;
            for (int i = 0; i < rtfList.Lines.Length; i++)
            {
                currentLine = rtfList.Lines[i].ToString().TrimEnd();
                if (currentLine.Length > 0)
                {
                    if (i != rtfList.Lines.Length - 1)
                    {
                        if (i != 0)
                        {
                            if (i % lineLimit == 0)
                            {
                                if (currentLine == "^")
                                {
                                    converted = converted + middle + Environment.NewLine;
                                }
                                else
                                {
                                    converted = converted + currentLine + "'," + Environment.NewLine + "'";
                                }
                            }
                            else
                            {
                                if (currentLine == "^")
                                {
                                    converted = converted + middle;
                                }
                                else
                                {
                                    converted = converted + currentLine + middle;
                                }
                            }
                        }
                        else
                        {
                            converted = converted + currentLine + middle;
                        }
                    }
                    else
                    {
                        if (currentLine == "^")
                        {
                            converted = converted + end;
                        }
                        else
                        {
                            converted = converted + currentLine + end;
                        }
                    }
                }
            }
            rowClicked = false;
            rtfOutputSQL.AppendText(converted);
        }

        private void btnHeader_Click(object sender, EventArgs e)
        {
            //
            int totalFields = 0;
            string currentLine = "";
            string[] currentSplitLine;
            string convertRTF = "";

            for (int z = 0; z < rtfList.Lines.Length; z++)
            {
                currentLine = rtfList.Lines[z];
                currentSplitLine = currentLine.Split('\t');
                for (int y = 0; y < currentSplitLine.Length; y++)
                {
                    if (currentSplitLine[y] == "") { currentSplitLine[y] = "^"; }
                    if (z == rtfList.Lines.Length && y == currentSplitLine.Length)
                        convertRTF = convertRTF + currentSplitLine[y].Trim();
                    else
                        convertRTF = convertRTF + currentSplitLine[y].Trim() + '\n';
                }
            }
            convertRTF = convertRTF.Remove(convertRTF.Length - 1);
            rtfList.Clear();
            rtfList.Text = convertRTF;
            //


            rtfOutputSQL.Text = "";
            int lineLimit = 10;
            currentLine = "";
            string beginning, end, middle;
            string end2, middle2;
            string converted = "";
            beginning = " INSERT INTO TABLE_NAME (";
            middle = ",";
            end = ")";

            middle2 = "','";
            end2 = "')";


            converted = beginning;
            //BUILD First half of Insert statement. They will not be surrounded by single quotes
            for (int i = 0; i < rtfList.Lines.Length / 2; i++)
            {
                currentLine = rtfList.Lines[i].ToString().TrimEnd();
                if (currentLine.Length > 0)
                {
                    if (i != rtfList.Lines.Length / 2 - 1)
                    {
                        if (i != 0)
                        {
                            if (i % lineLimit == 0)
                            {
                                if (currentLine == "^")
                                {
                                    converted = converted + middle + Environment.NewLine;
                                }
                                else
                                {
                                    converted = converted + currentLine + "," + Environment.NewLine;
                                }
                            }
                            else
                            {
                                if (currentLine == "^")
                                {
                                    converted = converted + middle;
                                }
                                else
                                {
                                    converted = converted + currentLine + middle;
                                }
                            }
                        }
                        else
                        {
                            converted = converted + currentLine + middle;
                        }
                    }
                    else
                    {
                        if (currentLine == "^")
                        {
                            converted = converted + end;
                        }
                        else
                        {
                            converted = converted + currentLine + end;
                        }
                    }
                }
            }
            converted = converted + " Values ('";
            //Build second part of insert statement. These are the values
            for (int j = rtfList.Lines.Length / 2; j < rtfList.Lines.Length; j++)
            {
                currentLine = rtfList.Lines[j].ToString().TrimEnd();
                if (currentLine.Length > 0)
                {
                    if (j != rtfList.Lines.Length - 1)
                    {
                        if (j != 0)
                        {
                            if (j % lineLimit == 0)
                            {
                                if (currentLine == "^")
                                {
                                    converted = converted + middle2 + Environment.NewLine;
                                }
                                else
                                {
                                    converted = converted + currentLine + "'," + Environment.NewLine + "'";
                                }
                            }
                            else
                            {
                                if (currentLine == "^")
                                {
                                    converted = converted + middle2;
                                }
                                else
                                {
                                    converted = converted + currentLine + middle2;
                                }
                            }
                        }
                        else
                        {
                            converted = converted + currentLine + middle2;
                        }
                    }
                    else
                    {
                        if (currentLine == "^")
                        {
                            converted = converted + end2;
                        }
                        else
                        {
                            converted = converted + currentLine + end2;
                        }
                    }
                }
            }


            rtfOutputSQL.AppendText(converted);
        }

        private void btnUpdate_stmnt_Click(object sender, EventArgs e)
        {
            int totalFields = 0;
            string currentLine = "";
            string[] currentSplitLine;
            string convertRTF = "";

            rtfOutputSQL.Text = "";
            int lineLimit = 10;
            currentLine = "";
            string beginning;
            string converted = "";
            beginning = "UPDATE TABLE_NAME \nSET ";


            string column_v = "";
            string row_v = "";

            converted = beginning;
            //Run first to clean up and make each item on a line
            for (int z = 0; z < rtfList.Lines.Length; z++)
            {
                currentLine = rtfList.Lines[z];
                currentSplitLine = currentLine.Split('\t');
                for (int y = 0; y < currentSplitLine.Length; y++)
                {
                    if (currentSplitLine[y] == "") { currentSplitLine[y] = ""; }
                    if (z == rtfList.Lines.Length && y == currentSplitLine.Length)
                        convertRTF = convertRTF + currentSplitLine[y].Trim();
                    else
                        convertRTF = convertRTF + currentSplitLine[y].Trim() + '\n';
                }
            }
            convertRTF = convertRTF.Remove(convertRTF.Length - 1);
            //BUILD 2nd half of Insert statement. They will not be surrounded by single quotes
            rtfList.Text = convertRTF;
            int length_Delim = rtfList.Lines.Length / 2;
            for (int i = 0; i < rtfList.Lines.Length / 2; i++)
            {
                if (rtfList.Lines[i].ToString().TrimEnd() != "timestamp")
                {
                    column_v = rtfList.Lines[i].ToString().TrimEnd();
                    row_v = rtfList.Lines[i + length_Delim].ToString().TrimEnd();
                    if (i == rtfList.Lines.Length / 2 - 1)
                    {
                        converted = converted + column_v + '=' + row_v + "\nWHERE FIELD_NAME = ''";
                    }
                    else
                        if (row_v == "NULL")
                    {
                        converted = converted + column_v + "=" + row_v + "," + '\n';
                    }
                    else
                        converted = converted + column_v + "='" + row_v + "'," + '\n';
                }
            }
            rtfOutputSQL.AppendText(converted);
        }

        private void btnRowConvert_Click(object sender, EventArgs e)
        {
            int totalFields = 0;
            string currentLine = "";
            string[] currentSplitLine;
            string convertRTF = "";

            for (int z = 0; z < rtfList.Lines.Length; z++)
            {
                currentLine = rtfList.Lines[z];
                currentSplitLine = currentLine.Split('\t');
                for (int y = 0; y < currentSplitLine.Length; y++)
                {
                    if (currentSplitLine[y] == "") { currentSplitLine[y] = "^"; }
                    if (z == rtfList.Lines.Length && y == currentSplitLine.Length)
                        convertRTF = convertRTF + currentSplitLine[y].Trim();
                    else
                        convertRTF = convertRTF + currentSplitLine[y].Trim() + '\n';
                }
            }
            convertRTF = convertRTF.Remove(convertRTF.Length - 1);
            rtfList.Clear();
            rtfList.Text = convertRTF;
            rowClicked = true;
            btnConvertSQL.PerformClick();
        }
    }
}
