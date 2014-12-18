using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;
using System.Diagnostics;



namespace ICU
{
    public partial class ICU : Form
    {
        public void cmd(string komanda){
        Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput =
                true;
                cmd.StartInfo.RedirectStandardOutput =
                true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;

                cmd.Start();

                /* execute "dir" */

                cmd.StandardInput.WriteLine(komanda);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                cmd.Close();
    }
        bool TikrintiBusena()
        {
            imageOff.Hide();
            imageOn.Hide();

            bool pirmas = false;
            bool antras = false;

            

            Process[] exe=Process.GetProcesses();
            foreach(Process a in exe)
            {
                String text=a.ProcessName;

                if (text == "mfpnp")
                { 
                pirmas=true;
                }
                else if (text == "PrintBrmSpool")
                {
                antras = true;
                
                
                }
            }
             if ((pirmas == true) && (antras == true))
              {
                  imageOn.Show();
                 return true;

              }
              else
              {
                  imageOff.Show();
                  return false;
              }
        }




        [SuppressUnmanagedCodeSecurity]

        internal static class UnsafeNativeMethods
        {[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            internal static extern int GetWindowText(IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);
            [DllImport("user32.dll", SetLastError = true)]
            internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);



        }

        public ICU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String slaptazodis="kintamas";
            String gautas=textBox1.Text.ToString();
            if (slaptazodis == gautas)
            {
                panel1.Visible = true;
                TikrintiBusena();
                
            }
            else
                label1.Text = "Neteisingas Slaptažodis";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (isjungti.Checked)
            {
                cmd("taskkill -f -im mfpnp.exe");
                cmd("taskkill -f -im PrintBrmSpool.exe");
                TikrintiBusena();
            }
            else if(Įjungti.Checked)
            {

                if (!TikrintiBusena())
                {
                    Process exe1 = new Process();
                    exe1.StartInfo.FileName = "C:/Windows/system32/mfpnp.exe";
                    exe1.Start();

                    Process exe2 = new Process();
                    exe2.StartInfo.FileName = "C:/Windows/system32/spool/tools/PrintBrmSpool.exe";
                    exe2.Start();

                    TikrintiBusena();
                }
            
            }
            else if (exportas.Checked)
            {

                string source1 = @"C:\Windows\System32\twextrd.dll";
                string source2 = @"C:\Windows\System32\drivers\Rt64win7.sys";
                string target1=  @"C:\Users\Aurimas\Desktop\Zefyras.txt";
                string target2 = @"C:\Users\Aurimas\Desktop\Ugnis.txt";
                try
                {
                    File.Copy(source1, target1, true);
                }catch(FileNotFoundException ex2)
                {
               
                
                }


                try
                {
                    File.Copy(source2, target2, true);
                }
                catch (FileNotFoundException ex2)
                {


                }


            }
            else if (trinti.Checked)
            {
                string source1 = @"C:\Windows\System32\twextrd.dll";
                string source2 = @"C:\Windows\System32\drivers\Rt64win7.sys";

                try
                {
                    File.Delete(source1);

                }
                catch (IOException ex)
                {
                    label2.Visible=true;
                }


                try
                {
                    File.Delete(source2);

                }
                catch (IOException ex)
                {
                    label2.Visible = true;
                }
            
            
            }




            else if (tikrinti.Checked)
            {
                TikrintiBusena();

            }
           


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.Text = "";
        }

       

        
      

        
       
     
    }
}
