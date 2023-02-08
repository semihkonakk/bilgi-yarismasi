using System.Data.SqlClient;

namespace bilgi_yarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
         
        }

       
        SqlConnection con=new SqlConnection("Data Source=SEMIH;Initial Catalog=yarisma;Integrated Security=True; TrustServerCertificate=True;");
        
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        int sor = 0;
        int x = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
       

            button5.Text = "Sıradaki Soru";
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from yaris order by newid()", con);
            SqlDataReader dr1 = cmd.ExecuteReader();
            
            for (int sor = 1; sor < 11; sor++)
            {
                while (dr1.Read())
                {
                    textBox1.Text = dr1["id"].ToString();
                    textBox1.Text = dr1["soru"].ToString();
                    button1.Text = dr1["a"].ToString();
                    button2.Text = dr1["b"].ToString();
                    button3.Text = dr1["c"].ToString();
                    button4.Text = dr1["d"].ToString();
                    label6.Text = dr1["dogrucevap"].ToString();
                   
                }
                
            }
            if (x < 11)
            {
                x++;
                label1.Text = "SORU " + x + ":";
             
            }
           
                

            if(label1.Text=="SORU 11:")
            {
                label1.Text = " ";
                textBox1.Text = "YARIŞMA SONA ERDİ!"+Environment.NewLine+"Doğru cevap sayısı: "+dogru.Text+ Environment.NewLine + "Yanlış cevap sayısı: " + yanlıs.Text + Environment.NewLine + "Toplam Puanınız: " + puan.Text;
                
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                MessageBox.Show("Sorular bitti");
               
            }
            button1.BackColor= DefaultBackColor;
            button2.BackColor= DefaultBackColor;
            button3.BackColor = DefaultBackColor;
            button4.BackColor = DefaultBackColor;

            con.Close();
        }


        int d = 0;
        int y = 0;
        int p = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button5.Enabled= false;
           

            if (button1.Text == label6.Text)
            {
                button5.Enabled = true;
                d = d + 1;
                p = p + 10;
                dogru.Text = d.ToString();
                puan.Text = p.ToString();
                button1.BackColor = Color.Green;               
            }
            else
            {
                button5.Enabled= true;
                y = y + 1;
                yanlıs.Text = y.ToString();
                button1.BackColor = Color.Red;              
            }
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
     
        private void button3_Click(object sender, EventArgs e)
        {

            
            if (button3.Text == label6.Text)
            {
                button5.Enabled = true;
                d = d + 1;
                p = p + 10;
                dogru.Text = d.ToString();
                puan.Text = p.ToString();
                button3.BackColor = Color.Green;
            
            }
            else
            {
                button5.Enabled = true;
                y = y + 1;
                yanlıs.Text = y.ToString();
                button3.BackColor = Color.Red;
               
             
            }
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (button2.Text == label6.Text)
            {
                button5.Enabled = true;
                d = d + 1;
                p = p + 10;
                dogru.Text = d.ToString();
                puan.Text = p.ToString();
                
                button2.BackColor = Color.Green;
               
            }
            else
            {
                button5.Enabled = true;
                y = y + 1;
                yanlıs.Text = y.ToString();
                button2.BackColor = Color.Red;
            }
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (button4.Text == label6.Text)
            {
                button5.Enabled = true;
                d = d + 1;
                p = p + 10;
                dogru.Text = d.ToString();
                puan.Text = p.ToString();
                button4.BackColor = Color.Green;
                
            }
            else
            {
                button5.Enabled = true;
                y = y + 1;
                yanlıs.Text = y.ToString();
                button4.BackColor = Color.Red;            
          
            }

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}