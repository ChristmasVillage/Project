﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChristmasVillageGUI.Proxies;
using ChristmasVillageBO;
using System.IO;
using System.Reflection;

namespace ChristmasVillage
{
    public partial class frmFactory : UserControl
    {
        /*
         * Déclaration des variables
         */
        private FactoryBO factory;
        private UserBO user;
        private frmVillage frmVillage;
        private int position;

        /* 
         * Initialisation de la Form frmFactory avec position en paramètre
         */
        public frmFactory(frmVillage frmVillage, UserBO user, int position)
        {
            InitializeComponent();
            this.frmVillage = frmVillage;
            this.user = user;
            this.position = position;

            btnManage.Visible = false;
            btnDelete.Visible = false;
            lblFactory.Visible = false;

            pictureBox.Image = Resource.ForSale;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /*
         * Initialisation de la Form frmFactory avec Factory en paramètre
         */
        public frmFactory(frmVillage frmVillage, UserBO user, FactoryBO factory)
        {
            InitializeComponent();
            this.frmVillage = frmVillage;
            this.user = user;
            this.factory = factory;

            btnAdd.Visible = false;

            pictureBox.Image = Resource.Factory;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /*
         * Affichage de la Form frmFactoryAdd avec paramètres ID Village et ID User
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id_village = frmVillage.manageVillage.id_village;
                int id_user = user.id_user;

                frmFactoryAdd objfrmFactoryAdd = new frmFactoryAdd(frmVillage, id_user, id_village, position);
                objfrmFactoryAdd.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Affichage de la Form frmFactoryManage avec paramètres frmVillage, User et Factory
         */
        private void btnManage_Click(object sender, EventArgs e)
        {
            try
            {
                frmFactoryManage objfrmFactoryManage = new frmFactoryManage(frmVillage, user, factory);
                objfrmFactoryManage.ShowDialog();
            }
            catch (Exception)
            {                
                throw;
            }
        }

        /*
         * Suppression de la Factory
         */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                 * Si capital > capitalMinimum -> suppression
                 * Sinon: Message "Votre capital ne permet pas la suppression."
                 */
                if (Utilities.checkCapital(user.capital))
                {
                    // Suppression du lien Factory -> Village
                    using (ManageFactoryIFACClient proxyManageFactory = new ManageFactoryIFACClient())
                    {
                        proxyManageFactory.deleteManageFactory(factory.id_factory);
                    }

                    // Suppression de la Factory
                    using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                    {
                        proxyFactory.deleteFactory(factory.id_factory);
                    }
                    frmVillage.reload(user);
                }
                else
                {
                    MessageBox.Show("Votre capital ne permet pas la suppression.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
