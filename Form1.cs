using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using workingcode.util;

namespace automata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XMLStateMachine dsm = new XMLStateMachine();
            dsm.StateTable = "disaster.xml";
            dsm.CurrentState = "start";
            
            
            DialogResult dialogResult = MessageBox.Show("Günlük çalışmanıza engel oluyor mu?", "Start", MessageBoxButtons.YesNo);

            while (dsm.Action != "dispense")
            {
              
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        dsm.Next("pozitif");
                        if(dsm.Action=="dispense")
                            MessageBox.Show(dsm.CurrentQuestion, dsm.CurrentState, MessageBoxButtons.OK);
                        else
                        dialogResult = MessageBox.Show(dsm.CurrentQuestion, dsm.CurrentState, MessageBoxButtons.YesNo);
                        break;
                    case DialogResult.No:
                        dsm.Next("negatif");
                        if (dsm.Action == "dispense")
                            MessageBox.Show(dsm.CurrentQuestion, dsm.CurrentState, MessageBoxButtons.OK);
                        else
                            dialogResult = MessageBox.Show(dsm.CurrentQuestion, dsm.CurrentState, MessageBoxButtons.YesNo);
                        break;
                   
                }
            }




        //    DialogResult dialogResult = MessageBox.Show("Günlük çalışmanıza engel oluyor mu?", "", MessageBoxButtons.YesNo);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            //pozitifse streptokokal ağ testi uygular
        //            dialogResult = MessageBox.Show("Testin sonucu pozitif mi?", "Ağır/Orta seyreden hastalık", MessageBoxButtons.YesNo);
        //            if (dialogResult == DialogResult.Yes)
        //            {
        //                //pozitifse penisilin uygular.
        //                dialogResult = MessageBox.Show("Hastanın penisiline alerjisi var mı?", "penisilin", MessageBoxButtons.YesNo);
        //                if (dialogResult == DialogResult.Yes)
        //                {
        //                    //antibiyotik uygula. FINAL STATE.

        //                }
        //                else if (dialogResult == DialogResult.No)
        //                {
        //                    //penisilin uygula. FINAL STATE.


        //                }
        //            }

        //            else if (dialogResult == DialogResult.No)
        //            {
        //                //negatifse bogaz kulturu uygula.
        //                dialogResult = MessageBox.Show("Testin sonucu pozitif mi?", "bogaz kulturu", MessageBoxButtons.YesNo);
        //                if (dialogResult == DialogResult.Yes)
        //                {
        //                    //pozitifse penisilin uygula.
        //                    dialogResult = MessageBox.Show("Hastanın penisiline alerjisi var mı?", "penisilin ", MessageBoxButtons.YesNo);
        //                    if (dialogResult == DialogResult.Yes)
        //                    {
        //                        //antibiyotik uygula. FINAL STATE.

        //                    }
        //                    else if (dialogResult == DialogResult.No)
        //                    {
        //                        //penisilin uygula. FINAL STATE.


        //                    }
        //                }
        //                else if (dialogResult == DialogResult.No)
        //                {
        //                    //semptomatik tedavi uygula.FINAL STATE.

        //                }
        //            }


        //        }


        //    }
        //    else if (dialogResult == DialogResult.No)
        //    {
        //        //negatifse hafif Ateşiniz var mı diye soracak.

        //        dialogResult = MessageBox.Show("Ateşiniz var mı?", "Hafif seyreden hastalık", MessageBoxButtons.YesNo);

        //        if (dialogResult == DialogResult.Yes)
        //        {
        //            //pozitifse streptokokal ağ testi uygular
        //            dialogResult = MessageBox.Show("Testin sonucu pozitif mi?", "streptokokal ağ testi", MessageBoxButtons.YesNo);
        //            if (dialogResult == DialogResult.Yes)
        //            {
        //                //pozitifse penisilin uygular.
        //                dialogResult = MessageBox.Show("Hastanın penisiline alerjisi var mı?", "penisilin", MessageBoxButtons.YesNo);
        //                if (dialogResult == DialogResult.Yes)
        //                {
        //                    //antibiyotik uygula. FINAL STATE.

        //                }
        //                else if (dialogResult == DialogResult.No)
        //                {
        //                    //penisilin uygula. FINAL STATE.


        //                }
        //            }

        //            else if (dialogResult == DialogResult.No)
        //            {
        //                //negatifse bogaz kulturu uygula.
        //                dialogResult = MessageBox.Show("Testin sonucu pozitif mi?", "bogaz kulturu", MessageBoxButtons.YesNo);
        //                if (dialogResult == DialogResult.Yes)
        //                {
        //                    //pozitifse penisilin uygula.
        //                    dialogResult = MessageBox.Show("Hastanın penisiline alerjisi var mı?", "penisilin", MessageBoxButtons.YesNo);
        //                    if (dialogResult == DialogResult.Yes)
        //                    {
        //                        //antibiyotik uygula. FINAL STATE.

        //                    }
        //                    else if (dialogResult == DialogResult.No)
        //                    {
        //                        //penisilin uygula. FINAL STATE.


        //                    }
        //                }
        //                else if (dialogResult == DialogResult.No)
        //                {
        //                    //semptomatik tedavi uygula.FINAL STATE.

        //                }
        //            }


        //        }

        //        else if (dialogResult == DialogResult.No)
        //        {
        //            //negatifse semptomatik tedavi uygular. FINAL STATE.


        //        }


        //    }




        //
        }


        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Our Team: \n\n Fatih Metin \n Ali Aşkın \n Fatih Çorlu \n Hakan Gökçen \n Yusuf Karakehya\n");
        }



    }
}
