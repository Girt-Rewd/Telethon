﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STELib;

namespace Telethon
{
    public partial class MonLogin : Form
    {
        string nomUtilisateur = "telethon2021";
        string motDePasse = "Don@2021";

        
        public MonLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (true/*nomUtilisateur.Equals(txtNom.Text) && motDePasse.Equals(txtMotDePasse.Text)*/)
            {
                Interface_temp monInterface = new Interface_temp();
                monInterface.Show();
            }
            else {
                Console.WriteLine("pas ok");
            }
        }
    }
}
