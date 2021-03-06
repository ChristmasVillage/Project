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
    public partial class frmFactoryAdd : Form
    {
        /*
         * Déclaration des variables
         */
        private int id_user;
        private int id_village;
        private int position;
        private FactoryTypeBO factoryType;
        private List<FactoryTypeBO> factoryTypeList;
        private frmVillage frmVillage;

        /*
         * Initialisation de la Form FactoryAdd
         */
        public frmFactoryAdd(frmVillage frmVillage, int id_user, int id_village, int position)
        {
            InitializeComponent();
            this.frmVillage = frmVillage;
            this.id_user = id_user;
            this.id_village = id_village;
            this.position = position;
        }

        /*
         * Chargement de la Form FactoryAdd
         * Population de la combobox avec la liste de FactoryType
         */
        private void frmFactoryAdd_Load(object sender, EventArgs e)
        {
            try
            {
                factoryTypeList = new List<FactoryTypeBO>();
                using (FactoryTypeIFACClient proxyFactoryType = new FactoryTypeIFACClient())
                {
                    factoryTypeList = proxyFactoryType.selectAll();
                    cbxFactoryType.DataSource = factoryTypeList;
                    cbxFactoryType.DisplayMember = "name";
                    cbxFactoryType.ValueMember = "id_factory_type";
                    cbxFactoryType.Text = " - Choose - ";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Fermeture de la From FactoryAdd
         */
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /*
         * Ajout d'une factory
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FactoryBO factory = new FactoryBO();
                ManageFactoryBO manageFactory = new ManageFactoryBO();
                List<ManageVillageBO> manageVillageList = new List<ManageVillageBO>();
                UserBO user = new UserBO();
                int price = Int32.Parse(lblFactoryPrice.Text);
                int capital;

                // Récupération de l'user et calcul du capital final
                using (UserIFACClient proxyUser = new UserIFACClient())
                {
                    user = proxyUser.findById(id_user);
                    capital = user.capital - price;
                }

                /*
                 * Si capital calculé plus grand que la capital minimum (500)
                 * True: Création factory, création lien factory->village, update user
                 * False: Afficher message "Plus assez d'argent..."
                 */
                if (Utilities.checkCapital(capital))
                {
                    // Création et récupération factory
                    using (FactoryIFACClient proxyFactory = new FactoryIFACClient())
                    {
                        factory.type = Int32.Parse(cbxFactoryType.SelectedValue.ToString());
                        factory.factory_location = position;
                        factory.toy_production_time = DateTime.Now;
                        factory.status = "false";
                        proxyFactory.createFactory(factory);
                        factory = proxyFactory.getLastFactory();
                    }

                    // Création du lien factory->village
                    using (ManageFactoryIFACClient proxyManageFactory = new ManageFactoryIFACClient())
                    {
                        manageFactory.id_village = id_village;
                        manageFactory.id_factory = factory.id_factory;
                        proxyManageFactory.createManageFactory(manageFactory);
                    }

                    // Update de l'user et rechargement de la Form Village
                    using (UserIFACClient proxyUser = new UserIFACClient())
                    {
                        user.capital = capital;
                        proxyUser.updateUser(user);
                        frmVillage.reload(user);
                    }
                    this.Dispose();
                    MessageBox.Show("Factory successfully created.");
                }
                else
                {
                    this.Dispose();
                    MessageBox.Show("Vous n'avez plus assez d'argent, économisez !");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         * Permet d'afficher les infos de FactoryType en fonction du choix
         */
        private void cbxFactoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                factoryType = new FactoryTypeBO();
                int id_FactoryType;
                if (Int32.TryParse(cbxFactoryType.SelectedValue.ToString(), out id_FactoryType))
                {
                    factoryType = factoryTypeList.Find(c => c.id_factory_type == id_FactoryType);
                    lblFactoryPrice.Text = factoryType.price.ToString();
                    lblPriceProduction.Text = factoryType.toy_production_price.ToString();
                    lblSalePrice.Text = factoryType.toy_sales_prices.ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
