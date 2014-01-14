using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Simulateur.Singleton;
using Simulateur.ManagerPerson;
using Simulateur.Comportement;
using Simulateur.Decorateur;
using Simulateur.Obeservateur;
using System.Threading;

namespace Simulateur
{
    public partial class Form1 : Form
    {
        private Cadeau Cible=null;
        private Archer PlayerArc = null;
        private Fantassin PlayerFan = null;
        private Chevalier PlayerChev = null;
        private Observer ObserverHandl = new Observer();
        Decoration decorer = null;
        Observer Observer = null;
        private PictureBox[,] Espace=new PictureBox[11,15];
        int ColonneCadeu = 0;
        int LigneCadeu = 0;
        string order = "h";
        Boolean PersonneEnEtatDeReceptionDesOrdres = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // timer1.Start();

            Observer = new Observer();
            Espace= Observer.DesignMyGame(flowLayoutPanel1);
           
           Observer.ChargerSimulation(Espace, "Archer", "Chevalier", "Fatassin");
            Cible = new Cadeau();
             LigneCadeu = int.Parse(Cible.GetPositionCadeau(Espace).Substring(0, 1));
             ColonneCadeu = int.Parse(Cible.GetPositionCadeau(Espace).Substring(1, 1));
            //timer1.Start();
        //   Cible =Cadeau.getInstance();
       //    PositionCadeau=Cible.();
      //     decorer = new Decoration();
      //     Espace = decorer.DesignMyGame(flowLayoutPanel1);
     //      decorer.ChargerSimulation(Espace, "Player1", "Player2", "Player3");
        
        //   flowLayoutPanel1.Controls.SetChildIndex(pictureBox55, PositionCadeau); 
         //  decorer.InterfaceDecoration(this.flowLayoutPanel1,pictureBox1, pictureBox101,pictureBox110, "Player1", "Player2", "Player3");
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  Cible = Cadeau.getInstance();
            // flowLayoutPanel1.Controls.Remove(
            
            //flowLayoutPanel1.Controls.SetChildIndex(Cadeau_pic, Cible.Put_Inti());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            
               //  foreach (PictureBox pic in Espace) {
       //        if (pic.Tag == "archer") { MessageBox.Show("Oui"); }
            
        //    }
            //Cadeau cd = new Cadeau();
            //MessageBox.Show(cd.GetPositionCadeau(Espace)+"");
          //  decorer = new Decoration();
          //  Espace = decorer.DesignMyGame(flowLayoutPanel1);
          //  decorer.ChargerSimulation(Espace, "Player1", "Player2", "Player3");
            
            //timer1.Stop();
          //  Cible = Cadeau.getInstance();
          //  PositionCadeau = Cible.Put_Inti();
          //  decorer = new Decoration();
          //  Espace = decorer.DesignMyGame(flowLayoutPanel1);
           // decorer.InterfaceDecoration(Espace, "Player1", "Player2", "Player3");
            
            //PlayerArc.Move(flowLayoutPanel1, PlayerArcher);
            //PlayerArc = new Archer("PlayerArcher");
         //  int PosNow= flowLayoutPanel1.Controls.GetChildIndex(PlayerArcher);
          /// PictureBox[] pic = (PictureBox)flowLayoutPanel1.Controls.Find("PictureBox"+PosNow, true);
        //   foreach (PictureBox p in flowLayoutPanel1.Controls.Find("PictureBox" + PosNow, true))
         //   {

           //          p.BackColor = Color.Black;
               
           // }
           
          // flowLayoutPanel1.Controls.SetChildIndex(PlayerArcher, PlayerArc.PutOnPosition());
      
        }

        private void flowLayoutPanel1_ParentChanged(object sender, EventArgs e)
        {
          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void flowLayoutPanel1_LocationChanged(object sender, EventArgs e)
        {
     
        }
        void AnimateFin() {
            int i = 0;
            foreach (PictureBox pic in flowLayoutPanel1.Controls) {
                if (pic.Enabled == true)
                {
                    flowLayoutPanel1.Controls.Remove(pic);
                }
            
            }
        
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
          Archer archer = new Archer("Archer");
          Fantassin fantassin = new Fantassin("Fantassin");
          Chevalier chevalier = new Chevalier("Chevalier");
       //   decorer = new Decoration();
       //   decorer.ChangeColor(flowLayoutPanel1);
            if(archer.SeDeplacer(Espace,LigneCadeu,ColonneCadeu, order,PersonneEnEtatDeReceptionDesOrdres,"archer",Properties.Resources.archer) )
            {
                timer1.Stop();
                MessageBox.Show("Message pour l'archer: Félécitation c'est toi le 1ere qu'il a attiendre la cible..");
            }
            Thread.Sleep(100);
            if (fantassin.SeDeplacer(Espace, LigneCadeu, ColonneCadeu, order, PersonneEnEtatDeReceptionDesOrdres, "fantassin", Properties.Resources.fantassin))
            {
                timer1.Stop();
                MessageBox.Show("Message pour fantassin: Félécitation c'est toi le 1ere qu'il a attiendre la cible..");
            }
            Thread.Sleep(100);
            if (chevalier.SeDeplacer(Espace, LigneCadeu, ColonneCadeu, order, PersonneEnEtatDeReceptionDesOrdres, "chevalier", Properties.Resources.chevalier))
            {
                timer1.Stop();
                MessageBox.Show("Message pour le chevalier: Félécitation c'est toi le 1ere qu'il a attiendre la cible..");
            }  
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

    


        private void configurerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (PictureBox pic in Espace)
                {

                    pic.BackColor = colorDialog1.Color;

                }
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void parametragesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
