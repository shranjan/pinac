//////////////////////////////////////////////////////////////////////////////////
//  ProgPlot.xaml.cs - Plotting                                                 //
//  ver 1.0                                                                     //
//                                                                              //
//  Language:      C#                                                           //
//  Platform:      Windows Vista                                                //
//  Application:   SPINACH                                                      //
//  Author:        Arunkumar K T (akyasara@syr.edu)                             //
//                 Abhay Ketkar  (asketkar@syr.edu)                             //
//                 Prateek Jain  (pjain02@syr.edu)                              //
//                 Rutu Pandya   (rkpandya@syr.edu)                             //
//////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Spinach
{
    /// <summary>
    /// Interaction logic for ProgPlot.xaml
    /// </summary>
    public partial class ProgPlot : Window
    {
        private string imagepath = "";
        List<double> PlotVals = new List<double>();
        private PlotReceiver plot;
        private int plotcount = 0;
        private string OrgImgPath = "";

        //private PngBitmapEncoder PBE;
        //private ImageSource Img;
        //private Image img;
        //private BitmapImage bmpSource = null;
        public ProgPlot(string path, List<double> Vals, PlotReceiver p)
        {
            InitializeComponent();
            plot = p;
            plot.newimage += new PlotReceiver.BmpImage(plot_newimage);
            OrgImgPath = path.Split('.')[0];
            imagepath = OrgImgPath+".png";
            //Img = (ImageSource)new ImageSourceConverter().ConvertFromString(imagepath);
            //Img.clo
            if (Vals.Count != 0)
            {
                if (Vals[0] == -1)
                {
                    if (Vals.Count >= 10)
                    {
                        gridParam.Visibility = Visibility.Visible;
                        txtCamPosX.Text = Vals[1].ToString();
                        txtCamPosY.Text = Vals[2].ToString();
                        txtCamPosZ.Text = Vals[3].ToString();
                        txtLookDirX.Text = Vals[4].ToString();
                        txtLookDirY.Text = Vals[5].ToString();
                        txtLookDirZ.Text = Vals[6].ToString();
                        txtNearPlane.Text = Vals[7].ToString();
                        txtFieldView.Text = Vals[8].ToString();
                        txtRotAngle.Text = Vals[9].ToString();
                    }
                }
                else
                {
                    gridParam.Visibility = Visibility.Hidden;
                    imgPlot.Margin.Left.Equals(10);
                    imgPlot.Margin.Right.Equals(10);
                    imgPlot.Margin.Top.Equals(10);
                    imgPlot.Margin.Bottom.Equals(10);

                }
            }
        }

        void plot_newimage(PngBitmapEncoder encoder, List<double> Vals)
        {
            Thread t = new Thread(new ThreadStart(
                delegate()
                {
                    this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(
                        delegate()
                        {
                            try
                            {
                                if (encoder != null)
                                {
                                    //PlotVals = listvalues;
                                    PngBitmapEncoder PBE = new PngBitmapEncoder();
                                    PBE.Frames.Add(BitmapFrame.Create(encoder.Frames[0].Clone()));
                                    //imagepath = OrgImgPath + plotcount.ToString()+".png";
                                    //plotcount++;
                                    //Guid g = new Guid();
                                    //imagepath = g.ToString();
                                    imagepath = System.Guid.NewGuid().ToString()+".png";
                                    System.IO.FileStream outStream = new System.IO.FileStream(imagepath, System.IO.FileMode.Create);
                                    //imagepath = plotpath;
                                    PBE.Save(outStream);
                                    outStream.Close();
                                    ShowPlot();
                                }
                            }
                            catch (Exception e)
                            {
                                System.Windows.MessageBox.Show("Error in enable plot:" + e.Message);
                            }
                            
                        }));
                }));
            t.Start();
        }

        private void frmPlot_Loaded(object sender, RoutedEventArgs e)
        {
            ShowPlot();
        }

       
        private void ShowPlot()
        {
            try
            {
                imgPlot.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(imagepath);
            }
            catch(Exception e)
            {   
                System.Windows.MessageBox.Show("No Plot: "+e.Message);
            }
        }

        private void btnPlot_Click(object sender, RoutedEventArgs e)
        {
            
            imgPlot.Source = null;
            imgPlot.Source = (ImageSource)new ImageSourceConverter().ConvertFromString("SPINACH - Program Editor.jpg");
            //string d = Directory.GetCurrentDirectory() + "\\SPINACH - Program Editor.png";
            PlotVals.Clear();
            PlotVals.Add(Convert.ToDouble(txtCamPosX.Text));
            PlotVals.Add(Convert.ToDouble(txtCamPosY.Text));
            PlotVals.Add(Convert.ToDouble(txtCamPosZ.Text));
            PlotVals.Add(Convert.ToDouble(txtLookDirX.Text));
            PlotVals.Add(Convert.ToDouble(txtLookDirY.Text));
            PlotVals.Add(Convert.ToDouble(txtLookDirZ.Text));
            PlotVals.Add(Convert.ToDouble(txtFarPlane.Text));
            PlotVals.Add(Convert.ToDouble(txtUpDirX.Text));
            PlotVals.Add(Convert.ToDouble(txtUpDirY.Text));
            PlotVals.Add(Convert.ToDouble(txtUpDirZ.Text));
            PlotVals.Add(Convert.ToDouble(txtNearPlane.Text));
            PlotVals.Add(Convert.ToDouble(txtFieldView.Text));
            PlotVals.Add(Convert.ToDouble(txtRotAngle.Text));
            PlotVals.Add(Convert.ToDouble(txtRotAxisX.Text));
            PlotVals.Add(Convert.ToDouble(txtRotAxisY.Text));
            PlotVals.Add(Convert.ToDouble(txtRotAxisZ.Text));
            plot.changecam(PlotVals);
        }

        private void frmPlot_Closed(object sender, EventArgs e)
        {
            plot.clearstuff();
            //Img = null;
            //imgPlot.Source = null;
            //imgPlot = null;
        }

        private void btnSavePlot_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "png files (*.png)|*.png";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    String tempPath = saveFileDialog1.FileName;
                    System.IO.File.Copy(imagepath, tempPath);
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show("Error: Could not Write file to disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
