using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk;
using System.Net;
using System.ServiceModel.Description;
using System.Runtime.Serialization;
using System.Xml;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace DeleteContactCRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                IOrganizationService service = getServices(txtServer.Text.Trim(), txtLoginId.Text.Trim(), txtPassword.Text.Trim());
                //OleDbConnection oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "c:\\abc\\data.xls" + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';");
                //oledbConn.Open();
                //OleDbCommand cmd = new OleDbCommand(); ;
                //OleDbDataAdapter oleda = new OleDbDataAdapter();
                //DataSet ds = new DataSet();
                //cmd.Connection = oledbConn;
                //cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "SELECT distinct([name]) FROM [Sheet1$]";
                //oleda = new OleDbDataAdapter(cmd);
                //oleda.Fill(ds);
                SqlConnection con = new SqlConnection("data source=.;user=sa;password=trident@123;initial catalog=kuoni");
                con.Open();
                SqlCommand cmd = new SqlCommand("select contactguid from tbltest", con);

                SqlDataReader dr = null;
                dr = cmd.ExecuteReader();
                int i = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Guid gi = new Guid(dr["contactguid"].ToString());
                        service.Delete("contact", gi);
                        i++;
                    }
                }
                MessageBox.Show("No of contact deleted- " + i.ToString());
                //Entity task = new Entity("task");
                //task.Attributes["subject"] = "delete test";
                //Guid g = service.Create(task);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
        public static IOrganizationService getServices(string url,string id, string pass)
        {

            try
            {
                //Authenticate using credentials of the logged in user;
                ClientCredentials Credentials = new ClientCredentials();
                Credentials.UserName.UserName = "sa_apin_crm";
                Credentials.UserName.Password = "apacCRM@6446";                
                //NetworkCredential nc = new NetworkCredential("sa_apin_crm", "apacCRM@6446");
                //Credentials.Windows.ClientCredential = nc;//CredentialCache.DefaultNetworkCredentials;
                //This URL needs to be updated to match the servername and Organization for the environment.
                Uri OrganizationUri = new Uri("https://kuoni.clientkonnect.com:444/XRMServices/2011/Organization.svc");
                OrganizationServiceProxy serviceProxy = new OrganizationServiceProxy(OrganizationUri, null, Credentials, null);
                IOrganizationService service = (IOrganizationService)serviceProxy;
                serviceProxy.EnableProxyTypes();
                return service;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string uploadFile()
        {
            string str = string.Empty;
            try
            {            
            }
            catch (Exception ep)
            {
            }
            return str;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
            DialogResult result = folderBrowserDialog1.ShowDialog();
            // OK button was pressed. 
            if (result == DialogResult.OK)
            {
                
            }

        }
        
    }

}
