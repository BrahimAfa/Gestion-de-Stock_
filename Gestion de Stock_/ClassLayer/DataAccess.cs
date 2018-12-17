using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Stock_.DAL
{
    class DataAccess
    {

     public static SqlConnection con = new SqlConnection(@Properties.Settings.Default.StringConnection);
        static SqlCommand cmd;
        static SqlDataAdapter da;
        public static DataSet MainData = new DataSet();
      
                      /* Here i'm gonna Start ADD Fonctions */     

        public  bool IsDone { get; private set; }
        // this proprieter  gives me the state of a fonction is been done(complete) or not (a problem in the midlle)
        public static bool cnxChecker;
        public DataAccess()
        { }

        

        #region Fille_Dataset  

        public static DataTable GetFamilles()
        {
            open();
            if (MainData.Tables["Familles"] != null)
            {
                MainData.Tables["Familles"].Clear();
            }
            da = new SqlDataAdapter("select * from Familles", con);
            da.Fill(MainData, "Familles");
            close();
            return MainData.Tables["Familles"];
        }
        public static DataTable GetArticles()
        {
            open();
            if (MainData.Tables["Articles"]!=null)
            {
                MainData.Tables["Articles"].Clear();
            }
           
            da = new SqlDataAdapter("select * from ARTICLES", con);
            da.Fill(MainData, "Articles");
            close();
            return MainData.Tables["Articles"];
            
        }
        public static DataTable GetClient()
        {
            open();
            if (MainData.Tables["Clients"] != null)
            {
                MainData.Tables["Clients"].Clear();
            }
            da = new SqlDataAdapter("select * from CLIENTS", con);
            da.Fill(MainData, "Clients");
            close();
            return MainData.Tables["Clients"];
           
        }
        public static DataTable GetDevis()
        {
            open();
           
            if (MainData.Tables["Devis"] != null)
            {
                MainData.Tables["Devis"].Clear();
            }
            da = new SqlDataAdapter("select * from Devis", con);
            da.Fill(MainData, "Devis");
            close();
            return MainData.Tables["Devis"];

        }
        public static DataTable GetRegType()
        {
            open();

            if (MainData.Tables["Type"] != null)
            {
                MainData.Tables["Type"].Clear();
            }
            da = new SqlDataAdapter("select * from TYPE_REGLEMENT", con);
            da.Fill(MainData, "Type");
            close();
            return MainData.Tables["Type"];

        }

        public static DataTable GetDetailDevis(string NumDevis)
        {
            open();

            if (MainData.Tables["D_Devis"] != null)
            {
                MainData.Tables["D_Devis"].Clear();
            }
            da = new SqlDataAdapter("select * from Detail_Devis where NUMDEVIS = '"+ NumDevis + "'", con);
            da.Fill(MainData, "D_Devis");
            close();
            return MainData.Tables["D_Devis"];

        }
       
        public static DataTable GetBL()
        {
            open();

            if (MainData.Tables["BL"] != null)
            {
                MainData.Tables["BL"].Clear();
            }
            da = new SqlDataAdapter("select * from BL", con);
            da.Fill(MainData, "BL");
            close();
            return MainData.Tables["BL"];
        }
        public static DataTable GetDetailBL(string NumBL)
        {
            open();

            if (MainData.Tables["D_BL"] != null)
            {
                MainData.Tables["D_BL"].Clear();
            }
            da = new SqlDataAdapter("select * from Detail_BL where NUMBL = '" + NumBL + "'", con);
            da.Fill(MainData, "D_BL");
            close();
            return MainData.Tables["D_BL"];

        }
        #endregion
        public DataTable GetDevisInfos(string NumDevis)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("Select * from Devis_Info where NumDevis = '" + NumDevis + "'", con);
            da.Fill(dt);
            return dt;
        }
        public  bool IsArticlExist(string Ref)
        {
           
            open();
          
            cmd = new SqlCommand("Select * from ARTICLES Where Ref = '"+Ref+"'",con);
            SqlDataReader dr= cmd.ExecuteReader();
            
            bool state = !dr.HasRows ? true : false;
            dr.Close();
            close();

            return state;
            
        }
        public decimal GetArticlePrixVent(string Ref)
        {
            open();
            cmd = new SqlCommand("SELECT PU_VENTE FROM ARTICLES WHERE REF = '" + Ref + "'", con);
            decimal PU_vent = (decimal)cmd.ExecuteScalar();
            close();
            return PU_vent;

        }
        public decimal GetTVA(string Ref)
        {
            try
            {
                open();
                decimal TXTVA = 0;
                cmd = new SqlCommand("SELECT TXTVA FROM ARTICLES WHERE REF = '" + Ref + "'", con);
                TXTVA = Convert.ToDecimal( cmd.ExecuteScalar());
                close();
                return TXTVA;
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
            return 0;
            
        }
        public static void open()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {

                    con.Open();
                }
                cnxChecker = true;
            }

            catch (Exception ex) //when( ex.InnerException is SqlException" you condition is true...")
            {
                cnxChecker = false;
                if (ex.GetType().IsAssignableFrom(typeof(System.Data.SqlClient.SqlException)))
                {

                    MessageBox.Show("you should check is your SQL EXPRESS Server running");
                    MessageBox.Show("anythign you do now is not gonna saved in our datatbase\n" +
                                     "so you should fix the problem first \n\n" +
                                  " Message Error : " + ex.Message + "");
                    
                    //else
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}

                } }
            }
        // override object.Equals
  

        static public void close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

      public  void Ajouter_BD(Manage_Stock ajouter, SqlParameter[] param=null, DataSet ds=null)
        {

            switch (ajouter)
            {
                case Manage_Stock.Article:
                    ajouter_Article(param);
                    break;
                case Manage_Stock.BL:
                   
                    ajouter_BL(ds);
                    break;
                case Manage_Stock.Devis:
                    ajouter_Devis(ds);
                    break;
                case Manage_Stock.Famille:
                    ajouter_Famille(param);
                    break;
                case Manage_Stock.Client:
                    ajouter_Client(param);
                    break;
           
                
     
                default:
                    break;
            }
        }

        #region FONCTION_ARTICLES
        void ajouter_Article(SqlParameter[] param)
        {
            // @REF,@IDFamille,@Desc,@PU_Achat,@PU_Vente,@QTE,@TXTVA
            try
            {

                open();
                cmd = new SqlCommand("Insert into ARTICLES values (@REF,@IDFamille,@Desc,@PU_Achat,@PU_Vente,@QTE,@TXTVA)", con);
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                close();
                IsDone = true;
            }
            catch (Exception ex)
            {
                IsDone = false;
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region FONCTION_CLIENT
        void ajouter_Client(SqlParameter[] param)
        {
            //                           @ID,@RaisonSocial,@Adresse,@Ville,@Tele
            try
            {

                open();
                cmd = new SqlCommand("Insert into CLIENTS values (@ID,@RaisonSocial,@Adresse,@Ville,@Tele)", con);
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                close();
                MessageBox.Show("Client Bien Ajouter");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region FONCTION_DEVIS
       
        void ajouter_Devis( DataSet ds)
        {
            //                         @NUM,@IDCLIENT,@OBSERV
            open();
            SqlTransaction trans = con.BeginTransaction();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = trans;

            try
            {

                        SqlParameter[] _params =new SqlParameter[]
                {
               // @NUM,@IDCLIENT,@OBSERV
                new SqlParameter("@NUM",ds.Tables["devis"].Rows[0]["NUM"].ToString()),
                 new SqlParameter("@IDCLIENT",Convert.ToInt32( ds.Tables["devis"].Rows[0]["IDCLIENT"].ToString())),
                  new SqlParameter("@OBSERV",ds.Tables["devis"].Rows[0]["OBSERV"].ToString())
                };


                cmd.CommandText = "Insert into DEVIS ( NUMDEVIS ,IDCLIENT,OBSERVATION) values (@NUM,@IDCLIENT,@OBSERV)";
                    cmd.Parameters.AddRange(_params);
                    cmd.ExecuteNonQuery();
              
              
                //clearing params to add new ones.
              
                //secondly adding  "Detail Devis" wuth his params.
                foreach (DataRow item in ds.Tables["Detail_Devis"].Rows)
                {
                    cmd.Parameters.Clear();
                    SqlParameter[] _param =new SqlParameter []
                        {
                
                            new SqlParameter("@NumDvis",item["NumDvis"].ToString()),
                             new SqlParameter("@REF",item["REF"].ToString()),
                              new SqlParameter("@QTE",Convert.ToInt32(item["QTE"])),
                                new SqlParameter("@PRIX_Vent",Convert.ToDecimal(item["PU"])),
                                  new SqlParameter("@TXREMIS",Convert.ToDecimal(item["TXREMIS"])),
                                    new SqlParameter("@PT_HTTC",Convert.ToDecimal(item["PT_HTTC"]))
                        };
                    cmd.CommandText = "Insert into DETAIL_DEVIS (NUMDEVIS,REF,QTE,PRIX_VENTEHT,TXREMISE,PT_TTC) values (@NumDvis,@REF,@QTE,@PRIX_Vent,@TXREMIS,@PT_HTTC)";

                    cmd.Parameters.AddRange(_param);
                    cmd.ExecuteNonQuery();
                }
                  
                    
              

                trans.Commit();
                
                IsDone = true; // if you asking whats done the adding Fonction is the one is done

            }
            catch (Exception ex)
            {
                // the main problem that caused the problem
                IsDone = false;
                MessageBox.Show(ex.Message);
                try
                {
                    //attempting to rollback and if there is a problem we show it
                    MessageBox.Show("entered to rollback");
                    trans.Rollback();
                }
                catch (Exception ex1)
                {

                    MessageBox.Show(ex1.Message);
                }

            }finally
            {
                close();
            }
        }

        #endregion

        #region FONCTION_BL
        void ajouter_BL(DataSet ds)
        {
            //                         @NUM,@IDCLIENT,@OBSERV
            open();
            SqlTransaction trans = con.BeginTransaction();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = trans;

            try
            {

                SqlParameter[] _params = new SqlParameter[]
                {
               // @NUM,@IDCLIENT,@OBSERV
            //    @NUM,@IDCLIENT,@OBSERV
                new SqlParameter("@NUM",ds.Tables["BL"].Rows[0]["NUM"].ToString()),
                 new SqlParameter("@IDCLIENT",Convert.ToInt32( ds.Tables["BL"].Rows[0]["IDCLIENT"].ToString())),
                  new SqlParameter("@OBSERV",ds.Tables["BL"].Rows[0]["OBSERV"].ToString())
                };


                cmd.CommandText = "Insert into BL ( NUMBL ,IDCLIENT,OBSERVATION) values (@NUM,@IDCLIENT,@OBSERV)";
                cmd.Parameters.AddRange(_params);
                cmd.ExecuteNonQuery();


                //clearing params to add new ones.

                //secondly adding  "Detail Devis" wuth his params.
                foreach (DataRow item in ds.Tables["Detail_BL"].Rows)
                {
                    cmd.Parameters.Clear();
                    SqlParameter[] _param = new SqlParameter[]
                        {
                          //  @REF,@NumBL,@QTE,@ORIX_Vent,@TXREMIS,@PT_HTTC
                            new SqlParameter("@NumBL",item["NumBL"].ToString()),
                             new SqlParameter("@REF",item["REF"].ToString()),
                              new SqlParameter("@QTE",Convert.ToInt32(item["QTE"])),
                                new SqlParameter("@PRIX_Vent",Convert.ToDecimal(item["PU"])),
                                  new SqlParameter("@TXREMIS",Convert.ToDecimal(item["TXREMIS"])),
                                    new SqlParameter("@PT_HTTC",Convert.ToDecimal(item["PT_HTTC"]))
                        };
                    cmd.CommandText = "Insert into DETAIL_BL (REF,NUMBL,QTE,PRIX_VENTEHT,TXREMISE,PT_TTC) values (@REF,@NumBL,@QTE,@PRIX_Vent,@TXREMIS,@PT_HTTC)";

                    cmd.Parameters.AddRange(_param);
                    cmd.ExecuteNonQuery();
                }




                trans.Commit();

                IsDone = true; // if you asking whats done the adding Fonction is the one is done

            }
            catch (Exception ex)
            {
                // the main problem that caused the problem
                IsDone = false;
                MessageBox.Show(ex.Message);
                try
                {
                    //attempting to rollback and if there is a problem we show it
                    MessageBox.Show("entered to rollback");
                    trans.Rollback();
                }
                catch (Exception ex1)
                {

                    MessageBox.Show(ex1.Message);
                }

            }
            finally
            {
                close();
            }
        }
        



        #endregion

        #region FONCTION_FAMILLE
        void ajouter_Famille(SqlParameter[] param)
        {
            //                           @famille
            try
            {
                //  SqlTransaction trans ;
                // ID famiile Increament automaticlly with the Trigger
                open();
                cmd = new SqlCommand("Insert into  Familles  (FAMILLE) values (@famille)", con);
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        public enum Manage_Stock
        {
            Article,
            BL,
            Devis,
            Famille,
            Client,
           
        }

      public static  string GeneratNums(bool IsBL=false)
        {
     
            string NumDevis;
            open();

            if (IsBL)
            {
            cmd = new SqlCommand("select Max(NUMBL) from BL", con);

            }
            else
            {
             cmd = new SqlCommand("select Max(NUMDEVIS) from Devis", con);

            }



            if (!cmd.ExecuteScalar().Equals(DBNull.Value))
            {
                NumDevis = (string)cmd.ExecuteScalar();
                var splitedNum = NumDevis.Split('/').ToArray();
                int Num = Convert.ToInt32(splitedNum[0]);
                Num++;
                NumDevis = String.Concat(Num.ToString("D5"), "/", DateTime.Now.Year);
                return NumDevis;
            }
            close();
            return String.Concat("00001", "/", DateTime.Now.Year);

          //  select Max(REF) from ARTICLES
        }
        public static string GeneratReglementsID()
        {

            string Reg;
            open();

                cmd = new SqlCommand("select Max(IdReg) from REGLEMENT", con);
            if (!cmd.ExecuteScalar().Equals(DBNull.Value))
            {
                Reg = (string)cmd.ExecuteScalar();
                var splitedNum = Reg.Split('-').ToArray();
                int Num = Convert.ToInt32(splitedNum[1]);
                Num++;
                Reg = String.Concat( "REG", "-", Num.ToString("D5"));
                return Reg;
            }
            close();
            return String.Concat("REG", "-", "00001");

            
        }
        public static string GeneratFactureID()
        {
            string Fact;
            open();

            cmd = new SqlCommand("select Max(NumFact) from FACTURE", con);

            if (!cmd.ExecuteScalar().Equals(DBNull.Value))
            {
                Fact = (string)cmd.ExecuteScalar();
                var splitedNum = Fact.Split('-').ToArray();
                int Num = Convert.ToInt32(splitedNum[1]);
                Num++;
                Fact = String.Concat("FACT", "-", Num.ToString("D5"));
                return Fact;
            }
            close();
            return String.Concat("FACT", "-", "00001");


        }
        public static string GeneratArticlesRef()
        {

            string Ref;
            open();

                cmd = new SqlCommand("select Max(REF) from ARTICLES", con);

            if (!cmd.ExecuteScalar().Equals(DBNull.Value))
            {
                Ref = (string)cmd.ExecuteScalar();
                var splitedNum = Ref.Split('-').ToArray();
                int Num = Convert.ToInt32(splitedNum[1]);
                Num++;
                Ref = String.Concat("REF", "-", Num.ToString("D5"));
                return Ref;
            }
            close();
            return String.Concat("REF", "-", "00001");

            //  
        }
        public (DataTable Devis,DataTable Detail_Devis) Bl_Par_Devis(string Ref)
        {
            open();
            DataTable Devis = new DataTable();
            DataTable Detail_Devis = new DataTable();

            da = new SqlDataAdapter("Select * from Devis where NumDevis = '" + Ref + "'", con);
            da.Fill(Devis);
            if (Devis.Rows.Count<=0)
            {
                IsDone = false;
                close();
                return( null,null);
                
            }
            da = new SqlDataAdapter("Select * from Detail_Devis where NumDevis = '" + Ref + "'", con);
            da.Fill(Detail_Devis);
            IsDone = true;
            close();
            return (Devis, Detail_Devis);
        }

        public (DataTable BL, DataTable Detail_BL) BL_INfo(string Ref)
        {
            open();
            DataTable BL = new DataTable();
            DataTable Detail_BL = new DataTable();

            da = new SqlDataAdapter("Select * from BL where NumBL = '" + Ref + "'", con);
            da.Fill(BL);
            if (BL.Rows.Count <= 0)
            {
                IsDone = false;
                close();
                return (null, null);

            }
            da = new SqlDataAdapter("Select * from Detail_BL where NumBL = '" + Ref + "'", con);
            da.Fill(Detail_BL);
            IsDone = true;
            close();
            return (BL, Detail_BL);
        }


        /* Here i'm gonna Start Delete Fonctions */


        public void Supprimer_BD(Manage_Stock ajouter,string PK)
        {

            switch (ajouter)
            {
                case Manage_Stock.Article:
                    IsDone = Suppr_Article(PK);
                    break;
                case Manage_Stock.BL:
                    IsDone = Suppr_BL(PK);
                    break;
                case Manage_Stock.Devis:
                    IsDone= Suppr_Devis(PK);
                    break;
                case Manage_Stock.Famille:
                            // NOT YET  
                    break;
                case Manage_Stock.Client:
                   IsDone= Suppr_CLIENTE(PK);
                    break;

                 

                default:
                    break;
            }
        }

        #region FONCTION_ARTICLES
        private bool Suppr_Article(string Ref)
        {
            open();

            try
            {
                SqlCommand cmd = new SqlCommand("Delete from Articles Where Ref='" + Ref + "'", con);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                close();
            }
            return false;

        }
        #endregion

        #region FONCTION_CLIENTS
        private bool Suppr_CLIENTE(string ID)
        {
            open();

            try
            {
                cmd = new SqlCommand("Delete from Clients Where IDCLIENT=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(ID));
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //throw;

            }
            finally
            {
                close();
            }
            return false;

        }
        #endregion

        #region FONCTION_Devis

        public void Suppr_Article_Devis(string Ref,string num)
        {
            open();

            try
            {
                //DETAIL_DEVIS (NUMDEVIS,REF,
                cmd = new SqlCommand("Delete from DETAIL_DEVIS Where REF=@Ref and NUMDEVIS=@Num", con);
                cmd.Parameters.AddWithValue("@Ref", Ref);
                cmd.Parameters.AddWithValue("@Num", num);
                cmd.ExecuteNonQuery();
           

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //throw;

            }
            finally
            {
                close();
            }
        

        }
        private bool Suppr_Devis(string num)
        {
            open();

            try
            {
                cmd = new SqlCommand("Delete from DETAIL_DEVIS Where NUMDEVIS=@Num", con);
                cmd.Parameters.AddWithValue("@Num", num);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete from Devis Where NUMDEVIS=@Num", con);
                cmd.Parameters.AddWithValue("@Num", num);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //throw;

            }
            finally
            {
                close();
            }
            return false;
        }
        #endregion

        #region FONCTION_BL

        public void Suppr_Article_BL(string Ref, string num)
        {
            open();

            try
            {
                //DETAIL_DEVIS (NUMDEVIS,REF,
                cmd = new SqlCommand("Delete from DETAIL_BL Where REF=@Ref and NUMBL=@Num", con);
                cmd.Parameters.AddWithValue("@Ref", Ref);
                cmd.Parameters.AddWithValue("@Num", num);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //throw;

            }
            finally
            {
                close();
            }


        }
        private bool Suppr_BL(string num)
        {
            open();

            try
            {
                cmd = new SqlCommand("Delete from DETAIL_BL Where NUMBL=@Num", con);
                cmd.Parameters.AddWithValue("@Num", num);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete from BL Where NUMBL=@Num", con);
                cmd.Parameters.AddWithValue("@Num", num);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //throw;

            }
            finally
            {
                close();
            }
            return false;
        }
        #endregion
        /* Here i'm gonna Start Modify Fonctions */

        public void Modifier_BD(Manage_Stock ajouter, SqlParameter[] param=null,DataSet ds=null)
        {

            switch (ajouter)
            {
                case Manage_Stock.Article:
                    Modifier_Article(param);
                    break;
                case Manage_Stock.BL:
                    Modifier_BL(ds);
                    break;
                case Manage_Stock.Devis:
                    Modifier_Devis(ds);
                    break;
                case Manage_Stock.Famille:

                    break;
                case Manage_Stock.Client:
                    IsDone = Modifier_Client(param);
                    break;



                default:
                    break;
            }
        }

        #region FONCTION_ARTICLES
        void Modifier_Article(SqlParameter[] param)
        {
            // @REF,@IDFamille,@Desc,@PU_Achat,@PU_Vente,@QTE,@TXTVA
            try
            {

                open();
                cmd = new SqlCommand("Update  ARTICLES set  IDFamille=@IDFamille,Description=@Desc,PU_Achat=@PU_Achat,PU_Vente=@PU_Vente,QTE_Stock=@QTE,TXTVA=@TXTVA where REF=@REF", con);
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                close();
                IsDone = true;
            }
            catch (Exception ex)
            {
                IsDone = false;
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        
        #region FONCTION_CLIENT
        bool Modifier_Client(SqlParameter[] param)
        {
            //                           @ID,@RaisonSocial,@Adresse,@Ville,@Tele
            try
            {

                open();

                cmd = new SqlCommand("Update  CLIENTS set RAISONSOCIALE = @RaisonSocial,ADRESSE = @Adresse,VILLE = @Ville,TEL = @Tele where IDCLIENT = @ID", con);
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                close();
                return true;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        #endregion
       
        #region FONCTION_DEVIS

        void Modifier_Devis(DataSet ds)
        {
            //                         @NUM,@IDCLIENT,@OBSERV
            open();
            SqlTransaction trans = con.BeginTransaction();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = trans;

            try
            {

                SqlParameter[] _params = new SqlParameter[]
        {
               // @NUM,@IDCLIENT,@OBSERV
                new SqlParameter("@NUM",ds.Tables["devis"].Rows[0]["NUM"].ToString()),
                 new SqlParameter("@IDCLIENT",Convert.ToInt32( ds.Tables["devis"].Rows[0]["IDCLIENT"].ToString())),
                  new SqlParameter("@OBSERV",ds.Tables["devis"].Rows[0]["OBSERV"].ToString())
        };


                cmd.CommandText = "Update DEVIS set IDCLIENT = @IDCLIENT,OBSERVATION = @OBSERV where NUMDEVIS = @NUM";
                cmd.Parameters.AddRange(_params);
                cmd.ExecuteNonQuery();


                //clearing params to add new ones.

                //secondly adding  "Detail Devis" wuth his params.
                foreach (DataRow item in ds.Tables["Detail_Devis"].Rows)
                {
                    cmd.Parameters.Clear();
                    SqlParameter[] _param = new SqlParameter[]
                        {

                            new SqlParameter("@NumDvis",item["NumDvis"].ToString()),
                             new SqlParameter("@REF",item["REF"].ToString()),
                              new SqlParameter("@QTE",Convert.ToInt32(item["QTE"])),
                                new SqlParameter("@PRIX_Vent",Convert.ToDecimal(item["PU"])),
                                  new SqlParameter("@TXREMIS",Convert.ToDecimal(item["TXREMIS"])),
                                    new SqlParameter("@PT_HTTC",Convert.ToDecimal(item["PT_HTTC"]))
                        };
                    cmd.CommandText = "Update DETAIL_DEVIS set QTE=@QTE,PRIX_VENTEHT=@PRIX_Vent,TXREMISE=@TXREMIS,PT_TTC=@PT_HTTC where NUMDEVIS = @NumDvis and REF = @REF";

                    cmd.Parameters.AddRange(_param);
                    cmd.ExecuteNonQuery();
                }




                trans.Commit();

                IsDone = true; // if you asking whats done the adding Fonction is the one is done

            }
            catch (Exception ex)
            {
                // the main problem that caused the problem
                IsDone = false;
                MessageBox.Show(ex.Message);
                try
                {
                    //attempting to rollback and if there is a problem we show it
                    MessageBox.Show("entered to rollback");
                    trans.Rollback();
                }
                catch (Exception ex1)
                {

                    MessageBox.Show(ex1.Message);
                }

            }
            finally
            {
                close();
            }
        }

        #endregion

        #region FONCTION_BL

       private void Modifier_BL(DataSet ds)
        {
            //                         @NUM,@IDCLIENT,@OBSERV
            open();
            SqlTransaction trans = con.BeginTransaction();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = trans;

            try
            {

                SqlParameter[] _params = new SqlParameter[]
        {
               // @NUM,@IDCLIENT,@OBSERV
                new SqlParameter("@NUM",ds.Tables["BL"].Rows[0]["NUM"].ToString()),
                 new SqlParameter("@IDCLIENT",Convert.ToInt32( ds.Tables["BL"].Rows[0]["IDCLIENT"].ToString())),
                  new SqlParameter("@OBSERV",ds.Tables["BL"].Rows[0]["OBSERV"].ToString())
        };


                cmd.CommandText = "Update BL set IDCLIENT = @IDCLIENT,OBSERVATION = @OBSERV where NUMBL = @NUM";
                cmd.Parameters.AddRange(_params);
                cmd.ExecuteNonQuery();


                //clearing params to add new ones.

                //secondly adding  "Detail Devis" wuth his params.
                foreach (DataRow item in ds.Tables["Detail_BL"].Rows)
                {
                    cmd.Parameters.Clear();
                    SqlParameter[] _param = new SqlParameter[]
                        {

                            new SqlParameter("@NumBL",item["NumBL"].ToString()),
                             new SqlParameter("@REF",item["REF"].ToString()),
                              new SqlParameter("@QTE",Convert.ToInt32(item["QTE"])),
                                new SqlParameter("@PRIX_Vent",Convert.ToDecimal(item["PU"])),
                                  new SqlParameter("@TXREMIS",Convert.ToDecimal(item["TXREMIS"])),
                                    new SqlParameter("@PT_HTTC",Convert.ToDecimal(item["PT_HTTC"]))
                        };
                    cmd.CommandText = "Update DETAIL_BL set QTE=@QTE,PRIX_VENTEHT=@PRIX_Vent,TXREMISE=@TXREMIS,PT_TTC=@PT_HTTC where NUMBL = @NumBL and REF = @REF";

                    cmd.Parameters.AddRange(_param);
                    cmd.ExecuteNonQuery();
                }




                trans.Commit();

                IsDone = true; // if you asking whats done the adding Fonction is the one is done

            }
            catch (Exception ex)
            {
                // the main problem that caused the problem
                IsDone = false;
                MessageBox.Show(ex.Message);
                try
                {
                    //attempting to rollback and if there is a problem we show it
                    MessageBox.Show("entered to rollback");
                    trans.Rollback();
                }
                catch (Exception ex1)
                {

                    MessageBox.Show(ex1.Message);
                }

            }
            finally
            {
                close();
            }
        }

        #endregion

        #region FONCTION_FAMILLE
        void Modifier_Famille(SqlParameter[] param)
        {
            //                           @famille
            try
            {
                //  SqlTransaction trans ;
                // ID famiile Increament automaticlly with the Trigger
                open();
                cmd = new SqlCommand("Insert into  Familles  (FAMILLE) values (@famille)", con);
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        // ADDED Fonction Reglement Facture ....

        public void AddFacture(DataSet ds)
        {
            //@numfact,@idclient,@datefact,@Montant
            open();
            SqlTransaction trans = con.BeginTransaction();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Transaction = trans;
            //   Facture Reg Detail_Reg
            try
            {
                SqlParameter[] _param =
                 {

                        new SqlParameter("@numfact", ds.Tables["Facture"].Rows[0][0].ToString()),
                        new SqlParameter("@idclient", int.Parse(ds.Tables["Facture"].Rows[0][1].ToString())),
                        new SqlParameter("@datefact", DateTime.Parse( ds.Tables["Facture"].Rows[0][2].ToString())),
                        new SqlParameter("@Montant", decimal.Parse( ds.Tables["Facture"].Rows[0][3].ToString()))

                };

               //Insert Into Facture;
                    cmd.CommandText =
 "Insert into FACTURE values (@numfact,@idclient,@datefact,@Montant)";
                    cmd.Parameters.AddRange(_param);
                    cmd.ExecuteNonQuery();
                // Clearing params
                    cmd.Parameters.Clear();

                //add new params;
                //add Reglement
                SqlParameter[] _param2 =
                {

                new SqlParameter("@numreg", ds.Tables["Reg"].Rows[0][0].ToString()),
                new SqlParameter("@datereg", DateTime.Parse(ds.Tables["Reg"].Rows[0][1].ToString())),
                new SqlParameter("@numfact", ds.Tables["Reg"].Rows[0][2].ToString())
            

                };


                cmd.CommandText = "Insert into REGLEMENT values (@numreg,@datereg,@numfact)";
                cmd.Parameters.AddRange(_param2);
                cmd.ExecuteNonQuery();

               

    

                //clearing params to add new ones.

                //secondly adding  "Detail Devis" wuth his params.


                foreach (DataRow item in ds.Tables["Detail_Reg"].Rows)
                {
                    cmd.Parameters.Clear();
                    SqlParameter[] _params = new SqlParameter[]
                        {
                          //  
                            new SqlParameter("@IdReg",item[0].ToString()),
                            new SqlParameter("@Idtype",int.Parse(item[1].ToString())),
                            new SqlParameter("@Montant",Convert.ToDecimal(item[2])),
                            new SqlParameter("@Ref",item[3].ToString()),
                            new SqlParameter("@DateEch",Convert.ToDateTime(item[4])),
                            new SqlParameter("@Encais",Convert.ToBoolean(item[5]))
                        };
                         cmd.CommandText = 
            "Insert into Detail_Reg Values (@IdReg,@Idtype,@Montant,@Ref,@DateEch,@Encais)";
                    cmd.Parameters.AddRange(_params);

                    cmd.ExecuteNonQuery();
                }




                trans.Commit();

                IsDone = true; // if you asking whats done the adding Fonction is the one is done

            }
            catch (Exception ex)
            {
                // the main problem that caused the problem
                IsDone = false;
                MessageBox.Show(ex.Message);
                try
                {
                    //attempting to rollback and if there is a problem we show it
                    MessageBox.Show("entered to rollback");
                    trans.Rollback();
                }
                catch (Exception ex1)
                {

                    MessageBox.Show(ex1.Message);
                }

            }
            finally
            {
                close();
            }

        }
    }


}
