﻿using ChristmasVillageBO;
using ChristmasVillageGUI.Proxies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasVillage
{
    public partial class frmSubscribe : Form
    {
        private static string nameVillage = "ChristmasVillage";
        private frmWelcome objfrmWelcome;

        // Initialisation de la Form frmSubscribe
        public frmSubscribe(frmWelcome objfrmWelcome)
        {
            InitializeComponent();
            this.objfrmWelcome = objfrmWelcome;
            
        }

        // Permet d'enregistrer l'User lors du clic sur "Confirm"
        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                // Vérification que les champs sont rempli
                if (!string.IsNullOrWhiteSpace(tbxUsername.Text) && !string.IsNullOrWhiteSpace(tbxPassword.Text) && !string.IsNullOrWhiteSpace(tbxEmail.Text))
                {
                    using (UserIFACClient proxyUser = new UserIFACClient())
                    {
                        UserBO user = new UserBO();
                        user.username = tbxUsername.Text;
                        user.password = tbxPassword.Text;
                        user.email = tbxEmail.Text;
                        user.capital = Utilities.capitalDefault;

                        // Vérification de la disponnibilté de l'Username
                        if (proxyUser.checkUniqueUsername(user))
                        {
                            // Création User
                            proxyUser.createUser(user);

                            UserBO newUser = new UserBO();
                            newUser = proxyUser.searchUser(user);

                            using (VillageIFACClient proxyVillage = new VillageIFACClient())
                            {
                                // Création du Village 
                                VillageBO village = new VillageBO();
                                village.name = nameVillage + newUser.id_user.ToString();
                                proxyVillage.createVillage(village);

                                VillageBO newVillage = new VillageBO();
                                newVillage = proxyVillage.findVillage(village.name);

                                // Création du lien Village -> User
                                using (ManageVillageIFACClient proxyManageVillage = new ManageVillageIFACClient())
                                {
                                    ManageVillageBO manageVillage = new ManageVillageBO();
                                    manageVillage.id_user = newUser.id_user;
                                    manageVillage.id_village = newVillage.id_village;
                                    proxyManageVillage.createManageVillage(manageVillage);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("L'username existe déjà.");
                        }
                    }
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Veuillez remplir les champs.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Fermeture de la Form frmSubscribe
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }       
    }
}
