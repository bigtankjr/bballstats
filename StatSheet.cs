using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace B_Ball_Stats
{
    public partial class StatSheet : Form
    {
        Player[] player = new Player[12];
        Double[] twovalueattempt = new Double[12];
        Double[] twovaluemade = new Double[12];
        Double[] threevalueattempt = new Double[12];
        Double[] threevaluemade = new Double[12];
        Double[] foulshotattempt = new Double[12];
        Double[] foulnumattempt = new Double[12];
        Double[] foulnummade = new Double[12];
        Double[] foulshotmade = new Double[12];
        Double[] assistnum = new Double[12];
        Double[] assistvalue = new double[12];
        Double[] turnovernum = new Double[12];
        Double[] turnovervalue = new double[12];
        Double[] offrebnum = new Double[12];
        Double[] offrebvalue = new double[12];
        Double[] defrebnum = new Double[12];
        Double[] defrebvalue = new double[12];
        Double[] deflectfstnum = new Double[12];
        Double[] deflectfstvalue = new double[12];
        Double[] deflectsndnum = new Double[12];
        Double[] deflectsndvalue = new double[12];
        String[] name = new String[12];
        String[] number = new string[12];
        String[] twoattmpt = new String[12];
        String[] twomde = new String[12];
        String[] threeattmpt = new String[12];
        String[] threemde = new String[12];
        String[] flattmpt = new String[12];
        String[] flamde = new String[12];
        String[] assist = new String[12];
        String[] turnover = new String[12];
        String[] reboff = new String[12];
        String[] rebdef = new String[12];
        String[] deflectfirst = new String[12];
        String[] deflectsecond = new String[12];
        Double[] twonumattempt1 = new Double[12];
        Double[] twonummade = new Double[12];
        Double[] threenumattempt1 = new Double[12];
        Double[] threenummade = new Double[12];
        TimeSpan[] totalplayertime = new TimeSpan[12];
        Double totaltwoattmpt, totaltwomade, totalthreeattmpt, totalthreemade, totalfoulattmpt, totalfoulmade,
            totalassist, totalturnover, totaloffreb, totaldefreb, totaldeflectfst, totaldeflectsnd = 0;
        String teamCode;
        Boolean change = true;
        public StatSheet()
        {
            InitializeComponent();
        }
        

 /*------------------------------------- Player1 Name------------------------------------------------------------------------------------*/
        private void nametxt1_TextChanged(object sender, EventArgs e)           //Set First player name
        {
            name[0] = nametxt1.Text;
            nametxt1.Text = name[0];
            nametimetxt1.Text = name[0];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn1_Click(object sender, EventArgs e)
        {
            

                if (change)
                {
                    nametxt1.BackColor = Color.LightSalmon;
                    twoattempttxt1.BackColor = Color.LightSalmon;
                    twomadetxt1.BackColor = Color.LightSalmon;
                    threeattempttxt1.BackColor = Color.LightSalmon;
                    threemadetxt1.BackColor = Color.LightSalmon;
                    flattmpttxt1.BackColor = Color.LightSalmon;
                    flamdettxt1.BackColor = Color.LightSalmon;
                    assisttxt1.BackColor = Color.LightSalmon;
                    turnovertxt1.BackColor = Color.LightSalmon;
                    offrebtxt1.BackColor = Color.LightSalmon;
                    defrebtxt1.BackColor = Color.LightSalmon;
                    deflfsttxt1.BackColor = Color.LightSalmon;
                    deflsndtxt1.BackColor = Color.LightSalmon;

                change = false;
                }
                else {  nametxt1.BackColor = Color.White;
                        twoattempttxt1.BackColor = Color.White;
                        twomadetxt1.BackColor = Color.White;
                        threeattempttxt1.BackColor = Color.White;
                        threemadetxt1.BackColor = Color.White;
                        flattmpttxt1.BackColor = Color.White;
                        flamdettxt1.BackColor = Color.White;
                        assisttxt1.BackColor = Color.White;
                        turnovertxt1.BackColor = Color.White;
                        offrebtxt1.BackColor = Color.White;
                        defrebtxt1.BackColor = Color.White;
                        deflfsttxt1.BackColor = Color.White;
                        deflsndtxt1.BackColor = Color.White;
                        change = true;
                }
            
        }
/*------------------------------------- Player1 Number----------------------------------------------------------------------------------*/
        private void textBox1_TextChanged(object sender, EventArgs e)              //set First player number
        {
            number[0] = textBox1.Text;
            textBox1.Text = number[0];
            textBox137.Text = number[0];
            textBox1.Show();
        }

/*------------------------------------- Player1 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn1_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt1.Text = "0";
            twonumattempt1[0] = twonumattempt1[0] + 1;
            twovalueattempt[0] = Double.Parse(twoattempttxt1.Text) + twonumattempt1[0] + twovaluemade[0];
            twoattempttxt1.Text = (twovalueattempt[0].ToString());
            twoattmpt[0] = twoattempttxt1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {                        
        }

        private void twoattempttxt1_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn1_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt1.Text = "0";
            twonumattempt1[0] = twonumattempt1[0] - 1;
            twovalueattempt[0] = Double.Parse(twoattempttxt1.Text) + twonumattempt1[0] + twovaluemade[0];
            twoattempttxt1.Text = (twovalueattempt[0].ToString());
            twoattmpt[0] = twoattempttxt1.Text;
        }

        private void twomadeaddbtn1_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt1.Text = "0";
            twomadetxt1.Text = "0";
            twonummade[0] = twonummade[0] + 1;

            twovaluemade[0] = Double.Parse(twomadetxt1.Text) + twonummade[0];
            twovalueattempt[0] = Double.Parse(twoattempttxt1.Text) + twonumattempt1[0] + twovaluemade[0];
            twoattempttxt1.Text = (twovalueattempt[0].ToString());
            twomadetxt1.Text = (twovaluemade[0].ToString());
            twomde[0] = twomadetxt1.Text;
        }

        private void twomadesubbtn1_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt1.Text = "0";
            twomadetxt1.Text = "0";
            twonummade[0] = twonummade[0] - 1;

            twovaluemade[0] = Double.Parse(twomadetxt1.Text) + twonummade[0];
            twovalueattempt[0] = Double.Parse(twoattempttxt1.Text) + twonumattempt1[0] + twovaluemade[0];
            twoattempttxt1.Text = (twovalueattempt[0].ToString());
            twomadetxt1.Text = (twovaluemade[0].ToString());
            twomde[0] = twomadetxt1.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn1_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt1.Text = "0";
            threenumattempt1[0] = threenumattempt1[0] + 1;
            threevalueattempt[0] = Double.Parse(threeattempttxt1.Text) + threenumattempt1[0] + threevaluemade[0];
            threeattempttxt1.Text = (threevalueattempt[0].ToString());
            threeattmpt[0] = threeattempttxt1.Text;
            
        }

        private void threeattsubbtn1_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt1.Text = "0";
            threenumattempt1[0] = threenumattempt1[0] - 1;
            threevalueattempt[0] = Double.Parse(threeattempttxt1.Text) + threenumattempt1[0] + threevaluemade[0];
            threeattempttxt1.Text = (threevalueattempt[0].ToString());
            threeattmpt[0] = threeattempttxt1.Text;
        }

        private void threemadeaddbtn1_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt1.Text = "0";
            threemadetxt1.Text = "0";
            threenummade[0] = threenummade[0] + 1;

            threevaluemade[0] = Double.Parse(threemadetxt1.Text) + threenummade[0];
            threevalueattempt[0] = Double.Parse(threeattempttxt1.Text) + threenumattempt1[0] + threevaluemade[0];
            threeattempttxt1.Text = (threevalueattempt[0].ToString());
            threemadetxt1.Text = (threevaluemade[0].ToString());
            threemde[0] = threemadetxt1.Text;
        }

        private void threemadesubbtn1_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt1.Text = "0";
            threemadetxt1.Text = "0";
            threenummade[0] = threenummade[0] - 1;

            threevaluemade[0] = Double.Parse(threemadetxt1.Text) + threenummade[0];
            threevalueattempt[0] = Double.Parse(threeattempttxt1.Text) + threenumattempt1[0] + threevaluemade[0];
            threeattempttxt1.Text = (threevalueattempt[0].ToString());
            threemadetxt1.Text = (threevaluemade[0].ToString());
            threemde[0] = threemadetxt1.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn1_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt1.Text = "0";
            foulnumattempt[0] = foulnumattempt[0] + 1;
            foulshotattempt[0] = Double.Parse(flattmpttxt1.Text) + foulnumattempt[0] + foulshotmade[0];

            flattmpttxt1.Text = (foulshotattempt[0].ToString());
            flattmpt[0] = flattmpttxt1.Text;


        }

        private void flattmptsubbtn1_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt1.Text = "0";
            foulnumattempt[0] = foulnumattempt[0] - 1;
            foulshotattempt[0] = Double.Parse(flattmpttxt1.Text) + foulnumattempt[0] + foulshotmade[0];

            flattmpttxt1.Text = (foulshotattempt[0].ToString());
            flattmpt[0] = flattmpttxt1.Text;
        }

        private void flmadeaddbtn1_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt1.Text = "0";
            flamdettxt1.Text = "0";
            foulnummade[0] = foulnummade[0] + 1;

            foulshotmade[0] = Double.Parse(flamdettxt1.Text) + foulnummade[0];
            foulshotattempt[0] = Double.Parse(flattmpttxt1.Text) + foulnumattempt[0] + foulshotmade[0];
            flattmpttxt1.Text = (foulshotattempt[0].ToString());
            flamdettxt1.Text = (foulshotmade[0].ToString());
            flamde[0] = flamdettxt1.Text;
        }

        private void flmadesubbtn1_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt1.Text = "0";
            flamdettxt1.Text = "0";
            foulnummade[0] = foulnummade[0] - 1;

            foulshotmade[0] = Double.Parse(flamdettxt1.Text) + foulnummade[0];
            foulshotattempt[0] = Double.Parse(flattmpttxt1.Text) + foulnumattempt[0] + foulshotmade[0];
            flattmpttxt1.Text = (foulshotattempt[0].ToString());
            flamdettxt1.Text = (foulshotmade[0].ToString());
            flamde[0] = flamdettxt1.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn1_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt1.Text = "0";
            assistnum[0] = assistnum[0] + 1;

            assistvalue[0] = Double.Parse(assisttxt1.Text) + assistnum[0];
            assisttxt1.Text = (assistvalue[0].ToString());
            assist[0] = assisttxt1.Text;
        }

        private void assistsubbtn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt1.Text = "0";
            assistnum[0] = assistnum[0] - 1;

            assistvalue[0] = Double.Parse(assisttxt1.Text) + assistnum[0];
            assisttxt1.Text = (assistvalue[0].ToString());
            assist[0] = assisttxt1.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn1_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt1.Text = "0";
            turnovernum[0] = turnovernum[0] + 1;
            turnovervalue[0] = Double.Parse(turnovertxt1.Text) + turnovernum[0];
            turnovertxt1.Text = (turnovervalue[0].ToString());
            turnover[0] = turnovertxt1.Text;
        }

        private void trnvrssubbtn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt1.Text = "0";
            turnovernum[0] = turnovernum[0] - 1;
            turnovervalue[0] = Double.Parse(turnovertxt1.Text) + turnovernum[0];
            turnovertxt1.Text = (turnovervalue[0].ToString());
            turnover[0] = turnovertxt1.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn1_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt1.Text = "0";
            offrebnum[0] = offrebnum[0] + 1;

            offrebvalue[0] = Double.Parse(offrebtxt1.Text) + offrebnum[0];
            offrebtxt1.Text = (offrebvalue[0].ToString());
            reboff[0] = offrebtxt1.Text;
        }

        private void offsubrebbtn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt1.Text = "0";
            offrebnum[0] = offrebnum[0] - 1;

            offrebvalue[0] = Double.Parse(offrebtxt1.Text) + offrebnum[0];
            offrebtxt1.Text = (offrebvalue[0].ToString());
            reboff[0] = offrebtxt1.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn1_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt1.Text = "0";
            defrebnum[0] = defrebnum[0] + 1;

            defrebvalue[0] = Double.Parse(defrebtxt1.Text) + defrebnum[0];
            defrebtxt1.Text = (defrebvalue[0].ToString());
            rebdef[0] = defrebtxt1.Text;
        }

        private void defsubrebbtn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt1.Text = "0";
            defrebnum[0] = defrebnum[0] - 1;

            defrebvalue[0] = Double.Parse(defrebtxt1.Text) + defrebnum[0];
            defrebtxt1.Text = (defrebvalue[0].ToString());
            rebdef[0] = defrebtxt1.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn1_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt1.Text = "0";
            deflectfstnum[0] = deflectfstnum[0] + 1;

            deflectfstvalue[0] = Double.Parse(deflfsttxt1.Text) + deflectfstnum[0];
            deflfsttxt1.Text = (deflectfstvalue[0].ToString());
            deflectfirst[0] = deflfsttxt1.Text;
        }

        private void deflectsubfstbtn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt1.Text = "0";
            deflectfstnum[0] = deflectfstnum[0] - 1;

            deflectfstvalue[0] = Double.Parse(deflfsttxt1.Text) + deflectfstnum[0];
            deflfsttxt1.Text = (deflectfstvalue[0].ToString());
            deflectfirst[0] = deflfsttxt1.Text;
        }

        private void deflectaddsndbtn1_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt1.Text = "0";
            deflectsndnum[0] = deflectsndnum[0] + 1;

            deflectsndvalue[0] = Double.Parse(deflsndtxt1.Text) + deflectsndnum[0];
            deflsndtxt1.Text = (deflectsndvalue[0].ToString());
            deflectsecond[0] = deflsndtxt1.Text;
        }

        private void deflectsubsndbtn1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt1.Text = "0";
            deflectsndnum[0] = deflectsndnum[0] - 1;

            deflectsndvalue[0] = Double.Parse(deflsndtxt1.Text) + deflectsndnum[0];
            deflsndtxt1.Text = (deflectsndvalue[0].ToString());
            deflectsecond[0] = deflsndtxt1.Text;
        }
        //Player[] player2 = new Player( teamCode,  name[0],  number[0],  twoattmpt[0],  twomade[0],  threeattmpt[0],  threemde[0],  flattmpt[0],
             //flamde,  assist,  trnvr,  offreb,  defreb,  dflctfirst,  dflctsecond);
        /*-------------------------------------------------------------------- END OF PLAYER1 ------------------------------------------------------------------*/

        /*------------------------------------- Player2 Name------------------------------------------------------------------------------------*/
        private void nametxt2_TextChanged(object sender, EventArgs e)           //Set Second player name
        {
            name[1] = nametxt2.Text;
            nametxt2.Text = name[1];
            nametimetxt2.Text = name[1];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn2_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt2.BackColor = Color.LightSalmon;
                twoattempttxt2.BackColor = Color.LightSalmon;
                twomadetxt2.BackColor = Color.LightSalmon;
                threeattempttxt2.BackColor = Color.LightSalmon;
                threemadetxt2.BackColor = Color.LightSalmon;
                flattmpttxt2.BackColor = Color.LightSalmon;
                flamdettxt2.BackColor = Color.LightSalmon;
                assisttxt2.BackColor = Color.LightSalmon;
                turnovertxt2.BackColor = Color.LightSalmon;
                offrebtxt2.BackColor = Color.LightSalmon;
                defrebtxt2.BackColor = Color.LightSalmon;
                deflfsttxt2.BackColor = Color.LightSalmon;
                deflsndtxt2.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt2.BackColor = Color.White;
                twoattempttxt2.BackColor = Color.White;
                twomadetxt2.BackColor = Color.White;
                threeattempttxt2.BackColor = Color.White;
                threemadetxt2.BackColor = Color.White;
                flattmpttxt2.BackColor = Color.White;
                flamdettxt2.BackColor = Color.White;
                assisttxt2.BackColor = Color.White;
                turnovertxt2.BackColor = Color.White;
                offrebtxt2.BackColor = Color.White;
                defrebtxt2.BackColor = Color.White;
                deflfsttxt2.BackColor = Color.White;
                deflsndtxt2.BackColor = Color.White;
                change = true;
            }
        }
        /*------------------------------------- Player2 Number----------------------------------------------------------------------------------*/
        private void textBox2_TextChanged(object sender, EventArgs e)              //set Second player number
        {
            number[1] = textBox2.Text;
            textBox2.Text = number[1];
            textBox135.Text = number[1];
            textBox2.Show();
        }

        /*------------------------------------- Player2 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn2_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt2.Text = "0";
            twonumattempt1[1] = twonumattempt1[1] + 1;
            twovalueattempt[1] = Double.Parse(twoattempttxt2.Text) + twonumattempt1[1] + twovaluemade[1];
            twoattempttxt2.Text = (twovalueattempt[1].ToString());
            twoattmpt[1] = twoattempttxt2.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt2_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn2_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt2.Text = "0";
            twonumattempt1[1] = twonumattempt1[1] - 1;
            twovalueattempt[1] = Double.Parse(twoattempttxt2.Text) + twonumattempt1[1] + twovaluemade[1];
            twoattempttxt2.Text = (twovalueattempt[1].ToString());
            twoattmpt[1] = twoattempttxt2.Text;
        }

        private void twomadeaddbtn2_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt2.Text = "0";
            twomadetxt2.Text = "0";
            twonummade[1] = twonummade[1] + 1;

            twovaluemade[1] = Double.Parse(twomadetxt2.Text) + twonummade[1];
            twovalueattempt[1] = Double.Parse(twoattempttxt2.Text) + twonumattempt1[1] + twovaluemade[1];
            twoattempttxt2.Text = (twovalueattempt[1].ToString());
            twomadetxt2.Text = (twovaluemade[1].ToString());
            twomde[1] = twomadetxt2.Text;
        }

        private void twomadesubbtn2_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt2.Text = "0";
            twomadetxt2.Text = "0";
            twonummade[1] = twonummade[1] - 1;

            twovaluemade[1] = Double.Parse(twomadetxt2.Text) + twonummade[1];
            twovalueattempt[1] = Double.Parse(twoattempttxt2.Text) + twonumattempt1[1] + twovaluemade[1];
            twoattempttxt2.Text = (twovalueattempt[1].ToString());
            twomadetxt2.Text = (twovaluemade[1].ToString());
            twomde[1] = twomadetxt2.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn2_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt2.Text = "0";
            threenumattempt1[1] = threenumattempt1[1] + 1;
            threevalueattempt[1] = Double.Parse(threeattempttxt2.Text) + threenumattempt1[1] + threevaluemade[1];
            threeattempttxt2.Text = (threevalueattempt[1].ToString());
            threeattmpt[1] = threeattempttxt2.Text;

        }

        private void threeattsubbtn2_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt2.Text = "0";
            threenumattempt1[1] = threenumattempt1[1] - 1;
            threevalueattempt[1] = Double.Parse(threeattempttxt2.Text) + threenumattempt1[1] + threevaluemade[1];
            threeattempttxt2.Text = (threevalueattempt[1].ToString());
            threeattmpt[1] = threeattempttxt2.Text;
        }

        private void threemadeaddbtn2_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt2.Text = "0";
            threemadetxt2.Text = "0";
            threenummade[1] = threenummade[1] + 1;

            threevaluemade[1] = Double.Parse(threemadetxt2.Text) + threenummade[1];
            threevalueattempt[1] = Double.Parse(threeattempttxt2.Text) + threenumattempt1[1] + threevaluemade[1];
            threeattempttxt2.Text = (threevalueattempt[1].ToString());
            threemadetxt2.Text = (threevaluemade[1].ToString());
            threemde[1] = threemadetxt2.Text;
        }

        private void threemadesubbtn2_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt2.Text = "0";
            threemadetxt2.Text = "0";
            threenummade[1] = threenummade[1] - 1;

            threevaluemade[1] = Double.Parse(threemadetxt2.Text) + threenummade[1];
            threevalueattempt[1] = Double.Parse(threeattempttxt2.Text) + threenumattempt1[1] + threevaluemade[1];
            threeattempttxt2.Text = (threevalueattempt[1].ToString());
            threemadetxt2.Text = (threevaluemade[1].ToString());
            threemde[1] = threemadetxt2.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn2_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt2.Text = "0";
            foulnumattempt[1] = foulnumattempt[1] + 1;
            foulshotattempt[1] = Double.Parse(flattmpttxt2.Text) + foulnumattempt[1] + foulshotmade[1];

            flattmpttxt2.Text = (foulshotattempt[1].ToString());
            flattmpt[1] = flattmpttxt2.Text;


        }

        private void flattmptsubbtn2_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt2.Text = "0";
            foulnumattempt[1] = foulnumattempt[1] - 1;
            foulshotattempt[1] = Double.Parse(flattmpttxt2.Text) + foulnumattempt[1] + foulshotmade[1];

            flattmpttxt2.Text = (foulshotattempt[1].ToString());
            flattmpt[1] = flattmpttxt2.Text;
        }

        private void flmadeaddbtn2_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt2.Text = "0";
            flamdettxt2.Text = "0";
            foulnummade[1] = foulnummade[1] + 1;

            foulshotmade[1] = Double.Parse(flamdettxt2.Text) + foulnummade[1];
            foulshotattempt[1] = Double.Parse(flattmpttxt2.Text) + foulnumattempt[1] + foulshotmade[1];
            flattmpttxt2.Text = (foulshotattempt[1].ToString());
            flamdettxt2.Text = (foulshotmade[1].ToString());
            flamde[1] = flamdettxt2.Text;
            flattmpt[1] = flattmpttxt2.Text;
        }

        private void flmadesubbtn2_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt2.Text = "0";
            flamdettxt2.Text = "0";
            foulnummade[1] = foulnummade[1] - 1;

            foulshotmade[1] = Double.Parse(flamdettxt2.Text) + foulnummade[1];
            foulshotattempt[1] = Double.Parse(flattmpttxt2.Text) + foulnumattempt[1] + foulshotmade[1];
            flattmpttxt2.Text = (foulshotattempt[1].ToString());
            flamdettxt2.Text = (foulshotmade[1].ToString());
            flamde[1] = flamdettxt2.Text;
            flattmpt[1] = flattmpttxt2.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn2_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt2.Text = "0";
            assistnum[1] = assistnum[1] + 1;

            assistvalue[1] = Double.Parse(assisttxt2.Text) + assistnum[1];
            assisttxt2.Text = (assistvalue[1].ToString());
            assist[1] = assisttxt2.Text;
        }

        private void assistsubbtn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt2.Text = "0";
            assistnum[1] = assistnum[1] - 1;

            assistvalue[1] = Double.Parse(assisttxt2.Text) + assistnum[1];
            assisttxt2.Text = (assistvalue[1].ToString());
            assist[1] = assisttxt2.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn2_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt2.Text = "0";
            turnovernum[1] = turnovernum[1] + 1;
            turnovervalue[1] = Double.Parse(turnovertxt2.Text) + turnovernum[1];
            turnovertxt2.Text = (turnovervalue[1].ToString());
            turnover[1] = turnovertxt2.Text;
        }

        private void trnvrssubbtn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt2.Text = "0";
            turnovernum[1] = turnovernum[1] - 1;
            turnovervalue[1] = Double.Parse(turnovertxt2.Text) + turnovernum[1];
            turnovertxt2.Text = (turnovervalue[1].ToString());
            turnover[1] = turnovertxt2.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn2_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt2.Text = "0";
            offrebnum[1] = offrebnum[1] + 1;

            offrebvalue[1] = Double.Parse(offrebtxt2.Text) + offrebnum[1];
            offrebtxt2.Text = (offrebvalue[1].ToString());
            reboff[1] = offrebtxt2.Text;
        }

        private void offsubrebbtn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt2.Text = "0";
            offrebnum[1] = offrebnum[1] - 1;

            offrebvalue[1] = Double.Parse(offrebtxt2.Text) + offrebnum[1];
            offrebtxt2.Text = (offrebvalue[1].ToString());
            reboff[1] = offrebtxt2.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn2_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt2.Text = "0";
            defrebnum[1] = defrebnum[1] + 1;

            defrebvalue[1] = Double.Parse(defrebtxt2.Text) + defrebnum[1];
            defrebtxt2.Text = (defrebvalue[1].ToString());
            rebdef[1] = defrebtxt2.Text;
        }

        private void defsubrebbtn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt2.Text = "0";
            defrebnum[1] = defrebnum[1] - 1;

            defrebvalue[1] = Double.Parse(defrebtxt2.Text) + defrebnum[1];
            defrebtxt2.Text = (defrebvalue[1].ToString());
            rebdef[1] = defrebtxt2.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn2_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt2.Text = "0";
            deflectfstnum[1] = deflectfstnum[1] + 1;

            deflectfstvalue[1] = Double.Parse(deflfsttxt2.Text) + deflectfstnum[1];
            deflfsttxt2.Text = (deflectfstvalue[1].ToString());
            deflectfirst[1] = deflfsttxt2.Text;
        }

        private void deflectsubfstbtn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt2.Text = "0";
            deflectfstnum[1] = deflectfstnum[1] - 1;

            deflectfstvalue[1] = Double.Parse(deflfsttxt2.Text) + deflectfstnum[1];
            deflfsttxt2.Text = (deflectfstvalue[1].ToString());
            deflectfirst[1] = deflfsttxt2.Text;
        }

        private void deflectaddsndbtn2_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt2.Text = "0";
            deflectsndnum[1] = deflectsndnum[1] + 1;

            deflectsndvalue[1] = Double.Parse(deflsndtxt2.Text) + deflectsndnum[1];
            deflsndtxt2.Text = (deflectsndvalue[1].ToString());
            deflectsecond[1] = deflsndtxt2.Text;
        }

        private void deflectsubsndbtn2_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt2.Text = "0";
            deflectsndnum[1] = deflectsndnum[1] - 1;

            deflectsndvalue[1] = Double.Parse(deflsndtxt2.Text) + deflectsndnum[1];
            deflsndtxt2.Text = (deflectsndvalue[1].ToString());
            deflectsecond[1] = deflsndtxt2.Text;
        }

      
        /*-------------------------------------------------------------------- END OF PLAYER2 ------------------------------------------------------------------*/

        /*------------------------------------- Player3 Name------------------------------------------------------------------------------------*/
        private void nametxt3_TextChanged(object sender, EventArgs e)           //Set Third player name
        {
            name[2] = nametxt3.Text;
            nametxt3.Text = name[2];
            nametimetxt3.Text = name[2];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn3_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt3.BackColor = Color.LightSalmon;
                twoattempttxt3.BackColor = Color.LightSalmon;
                twomadetxt3.BackColor = Color.LightSalmon;
                threeattempttxt3.BackColor = Color.LightSalmon;
                threemadetxt3.BackColor = Color.LightSalmon;
                flattmpttxt3.BackColor = Color.LightSalmon;
                flamdettxt3.BackColor = Color.LightSalmon;
                assisttxt3.BackColor = Color.LightSalmon;
                turnovertxt3.BackColor = Color.LightSalmon;
                offrebtxt3.BackColor = Color.LightSalmon;
                defrebtxt3.BackColor = Color.LightSalmon;
                deflfsttxt3.BackColor = Color.LightSalmon;
                deflsndtxt3.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt3.BackColor = Color.White;
                twoattempttxt3.BackColor = Color.White;
                twomadetxt3.BackColor = Color.White;
                threeattempttxt3.BackColor = Color.White;
                threemadetxt3.BackColor = Color.White;
                flattmpttxt3.BackColor = Color.White;
                flamdettxt3.BackColor = Color.White;
                assisttxt3.BackColor = Color.White;
                turnovertxt3.BackColor = Color.White;
                offrebtxt3.BackColor = Color.White;
                defrebtxt3.BackColor = Color.White;
                deflfsttxt3.BackColor = Color.White;
                deflsndtxt3.BackColor = Color.White;
                change = true;
            }

        }

        /*------------------------------------- Player3 Number----------------------------------------------------------------------------------*/
        private void textBox3_TextChanged(object sender, EventArgs e)              //set Third player number
        {
            number[2] = textBox3.Text;
            textBox3.Text = number[2];
            textBox132.Text = number[2];
            textBox3.Show();
        }

        /*------------------------------------- Player3 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn3_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt3.Text = "0";
            twonumattempt1[2] = twonumattempt1[2] + 1;
            twovalueattempt[2] = Double.Parse(twoattempttxt3.Text) + twonumattempt1[2] + twovaluemade[2];
            twoattempttxt3.Text = (twovalueattempt[2].ToString());
            twoattmpt[2] = twoattempttxt3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt3_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn3_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt3.Text = "0";
            twonumattempt1[2] = twonumattempt1[2] - 1;
            twovalueattempt[2] = Double.Parse(twoattempttxt3.Text) + twonumattempt1[2] + twovaluemade[2];
            twoattempttxt3.Text = (twovalueattempt[2].ToString());
            twoattmpt[2] = twoattempttxt3.Text;
        }

        private void twomadeaddbtn3_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt3.Text = "0";
            twomadetxt3.Text = "0";
            twonummade[2] = twonummade[2] + 1;

            twovaluemade[2] = Double.Parse(twomadetxt3.Text) + twonummade[2];
            twovalueattempt[2] = Double.Parse(twoattempttxt3.Text) + twonumattempt1[2] + twovaluemade[2];
            twoattempttxt3.Text = (twovalueattempt[2].ToString());
            twomadetxt3.Text = (twovaluemade[2].ToString());
            twomde[2] = twomadetxt3.Text;
        }

        private void twomadesubbtn3_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt3.Text = "0";
            twomadetxt3.Text = "0";
            twonummade[2] = twonummade[2] - 1;

            twovaluemade[2] = Double.Parse(twomadetxt3.Text) + twonummade[2];
            twovalueattempt[2] = Double.Parse(twoattempttxt3.Text) + twonumattempt1[2] + twovaluemade[2];
            twoattempttxt3.Text = (twovalueattempt[2].ToString());
            twomadetxt3.Text = (twovaluemade[2].ToString());
            twomde[2] = twomadetxt3.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn3_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt3.Text = "0";
            threenumattempt1[2] = threenumattempt1[2] + 1;
            threevalueattempt[2] = Double.Parse(threeattempttxt3.Text) + threenumattempt1[2] + threevaluemade[2];
            threeattempttxt3.Text = (threevalueattempt[2].ToString());
            threeattmpt[2] = threeattempttxt3.Text;

        }

        private void threeattsubbtn3_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt3.Text = "0";
            threenumattempt1[2] = threenumattempt1[2] - 1;
            threevalueattempt[2] = Double.Parse(threeattempttxt3.Text) + threenumattempt1[2] + threevaluemade[2];
            threeattempttxt3.Text = (threevalueattempt[2].ToString());
            threeattmpt[2] = threeattempttxt3.Text;
        }

        private void threemadeaddbtn3_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt3.Text = "0";
            threemadetxt3.Text = "0";
            threenummade[2] = threenummade[2] + 1;

            threevaluemade[2] = Double.Parse(threemadetxt3.Text) + threenummade[2];
            threevalueattempt[2] = Double.Parse(threeattempttxt3.Text) + threenumattempt1[2] + threevaluemade[2];
            threeattempttxt3.Text = (threevalueattempt[2].ToString());
            threemadetxt3.Text = (threevaluemade[2].ToString());
            threemde[2] = threemadetxt3.Text;
        }

        private void threemadesubbtn3_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt3.Text = "0";
            threemadetxt3.Text = "0";
            threenummade[2] = threenummade[2] - 1;

            threevaluemade[2] = Double.Parse(threemadetxt3.Text) + threenummade[2];
            threevalueattempt[2] = Double.Parse(threeattempttxt3.Text) + threenumattempt1[2] + threevaluemade[2];
            threeattempttxt3.Text = (threevalueattempt[2].ToString());
            threemadetxt3.Text = (threevaluemade[2].ToString());
            threemde[2] = threemadetxt3.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn3_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt3.Text = "0";
            foulnumattempt[2] = foulnumattempt[2] + 1;
            foulshotattempt[2] = Double.Parse(flattmpttxt3.Text) + foulnumattempt[2] + foulshotmade[2];

            flattmpttxt3.Text = (foulshotattempt[2].ToString());
            flattmpt[2] = flattmpttxt3.Text;


        }

        private void flattmptsubbtn3_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt3.Text = "0";
            foulnumattempt[2] = foulnumattempt[2] - 1;
            foulshotattempt[2] = Double.Parse(flattmpttxt3.Text) + foulnumattempt[2] + foulshotmade[2];

            flattmpttxt3.Text = (foulshotattempt[2].ToString());
            flattmpt[2] = flattmpttxt3.Text;
        }

        private void flmadeaddbtn3_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt3.Text = "0";
            flamdettxt3.Text = "0";
            foulnummade[2] = foulnummade[2] + 1;

            foulshotmade[2] = Double.Parse(flamdettxt3.Text) + foulnummade[2];
            foulshotattempt[2] = Double.Parse(flattmpttxt3.Text) + foulnumattempt[2] + foulshotmade[2];
            flattmpttxt3.Text = (foulshotattempt[2].ToString());
            flamdettxt3.Text = (foulshotmade[2].ToString());
            flamde[2] = flamdettxt3.Text;
        }

        private void flmadesubbtn3_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt3.Text = "0";
            flamdettxt3.Text = "0";
            foulnummade[2] = foulnummade[2] - 1;

            foulshotmade[2] = Double.Parse(flamdettxt3.Text) + foulnummade[2];
            foulshotattempt[2] = Double.Parse(flattmpttxt3.Text) + foulnumattempt[2] + foulshotmade[2];
            flattmpttxt3.Text = (foulshotattempt[2].ToString());
            flamdettxt3.Text = (foulshotmade[2].ToString());
            flamde[2] = flamdettxt3.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn3_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt3.Text = "0";
            assistnum[2] = assistnum[2] + 1;

            assistvalue[2] = Double.Parse(assisttxt3.Text) + assistnum[2];
            assisttxt3.Text = (assistvalue[2].ToString());
            assist[2] = assisttxt3.Text;
        }

        private void assistsubbtn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt3.Text = "0";
            assistnum[2] = assistnum[2] - 1;

            assistvalue[2] = Double.Parse(assisttxt3.Text) + assistnum[2];
            assisttxt3.Text = (assistvalue[2].ToString());
            assist[2] = assisttxt3.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn3_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt3.Text = "0";
            turnovernum[2] = turnovernum[2] + 1;
            turnovervalue[2] = Double.Parse(turnovertxt3.Text) + turnovernum[2];
            turnovertxt3.Text = (turnovervalue[2].ToString());
            turnover[2] = turnovertxt3.Text;
        }

        private void trnvrssubbtn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt3.Text = "0";
            turnovernum[2] = turnovernum[2] - 1;
            turnovervalue[2] = Double.Parse(turnovertxt3.Text) + turnovernum[2];
            turnovertxt3.Text = (turnovervalue[2].ToString());
            turnover[2] = turnovertxt3.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn3_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt3.Text = "0";
            offrebnum[2] = offrebnum[2] + 1;

            offrebvalue[2] = Double.Parse(offrebtxt3.Text) + offrebnum[2];
            offrebtxt3.Text = (offrebvalue[2].ToString());
            reboff[2] = offrebtxt3.Text;
        }

        private void offsubrebbtn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt3.Text = "0";
            offrebnum[2] = offrebnum[2] - 1;

            offrebvalue[2] = Double.Parse(offrebtxt3.Text) + offrebnum[2];
            offrebtxt3.Text = (offrebvalue[2].ToString());
            reboff[2] = offrebtxt3.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn3_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt3.Text = "0";
            defrebnum[2] = defrebnum[2] + 1;

            defrebvalue[2] = Double.Parse(defrebtxt3.Text) + defrebnum[2];
            defrebtxt3.Text = (defrebvalue[2].ToString());
            rebdef[2] = defrebtxt3.Text;
        }

        private void defsubrebbtn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt3.Text = "0";
            defrebnum[2] = defrebnum[2] - 1;

            defrebvalue[2] = Double.Parse(defrebtxt3.Text) + defrebnum[2];
            defrebtxt3.Text = (defrebvalue[2].ToString());
            rebdef[2] = defrebtxt3.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn3_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt3.Text = "0";
            deflectfstnum[2] = deflectfstnum[2] + 1;

            deflectfstvalue[2] = Double.Parse(deflfsttxt3.Text) + deflectfstnum[2];
            deflfsttxt3.Text = (deflectfstvalue[2].ToString());
            deflectfirst[2] = deflfsttxt3.Text;
        }

        private void deflectsubfstbtn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt3.Text = "0";
            deflectfstnum[2] = deflectfstnum[2] - 1;

            deflectfstvalue[2] = Double.Parse(deflfsttxt3.Text) + deflectfstnum[2];
            deflfsttxt3.Text = (deflectfstvalue[2].ToString());
            deflectfirst[2] = deflfsttxt3.Text;
        }

        private void deflectaddsndbtn3_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt3.Text = "0";
            deflectsndnum[2] = deflectsndnum[2] + 1;

            deflectsndvalue[2] = Double.Parse(deflsndtxt3.Text) + deflectsndnum[2];
            deflsndtxt3.Text = (deflectsndvalue[2].ToString());
            deflectsecond[2] = deflsndtxt3.Text;
        }

        private void deflectsubsndbtn3_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt3.Text = "0";
            deflectsndnum[2] = deflectsndnum[2] - 1;

            deflectsndvalue[2] = Double.Parse(deflsndtxt3.Text) + deflectsndnum[2];
            deflsndtxt3.Text = (deflectsndvalue[2].ToString());
            deflectsecond[2] = deflsndtxt3.Text;
        }
        /*-------------------------------------------------------------------- END OF PLAYER3 ------------------------------------------------------------------*/

        /*------------------------------------- Player4 Name------------------------------------------------------------------------------------*/
        private void nametxt4_TextChanged(object sender, EventArgs e)           //Set Fourth player name
        {
            name[3] = nametxt4.Text;
            nametxt4.Text = name[3];
            nametimetxt4.Text = name[3];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn4_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt4.BackColor = Color.LightSalmon;
                twoattempttxt4.BackColor = Color.LightSalmon;
                twomadetxt4.BackColor = Color.LightSalmon;
                threeattempttxt4.BackColor = Color.LightSalmon;
                threemadetxt4.BackColor = Color.LightSalmon;
                flattmpttxt4.BackColor = Color.LightSalmon;
                flamdettxt4.BackColor = Color.LightSalmon;
                assisttxt4.BackColor = Color.LightSalmon;
                turnovertxt4.BackColor = Color.LightSalmon;
                offrebtxt4.BackColor = Color.LightSalmon;
                defrebtxt4.BackColor = Color.LightSalmon;
                deflfsttxt4.BackColor = Color.LightSalmon;
                deflsndtxt4.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt4.BackColor = Color.White;
                twoattempttxt4.BackColor = Color.White;
                twomadetxt4.BackColor = Color.White;
                threeattempttxt4.BackColor = Color.White;
                threemadetxt4.BackColor = Color.White;
                flattmpttxt4.BackColor = Color.White;
                flamdettxt4.BackColor = Color.White;
                assisttxt4.BackColor = Color.White;
                turnovertxt4.BackColor = Color.White;
                offrebtxt4.BackColor = Color.White;
                defrebtxt4.BackColor = Color.White;
                deflfsttxt4.BackColor = Color.White;
                deflsndtxt4.BackColor = Color.White;
                change = true;
            }

        }
        /*------------------------------------- Player4 Number----------------------------------------------------------------------------------*/
        private void textBox4_TextChanged(object sender, EventArgs e)              //set Fourth player number
        {
            number[3] = textBox4.Text;
            textBox4.Text = number[3];
            textBox131.Text = number[3];
            textBox4.Show();
        }

        /*------------------------------------- Player4 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn4_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt4.Text = "0";
            twonumattempt1[3] = twonumattempt1[3] + 1;
            twovalueattempt[3] = Double.Parse(twoattempttxt4.Text) + twonumattempt1[3] + twovaluemade[3];
            twoattempttxt4.Text = (twovalueattempt[3].ToString());
            twoattmpt[3] = twoattempttxt4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt4_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn4_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt4.Text = "0";
            twonumattempt1[3] = twonumattempt1[3] - 1;
            twovalueattempt[3] = Double.Parse(twoattempttxt4.Text) + twonumattempt1[3] + twovaluemade[3];
            twoattempttxt4.Text = (twovalueattempt[3].ToString());
            twoattmpt[3] = twoattempttxt4.Text;
        }

        private void twomadeaddbtn4_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt4.Text = "0";
            twomadetxt4.Text = "0";
            twonummade[3] = twonummade[3] + 1;

            twovaluemade[3] = Double.Parse(twomadetxt4.Text) + twonummade[3];
            twovalueattempt[3] = Double.Parse(twoattempttxt4.Text) + twonumattempt1[3] + twovaluemade[3];
            twoattempttxt4.Text = (twovalueattempt[3].ToString());
            twomadetxt4.Text = (twovaluemade[3].ToString());
            twomde[3] = twomadetxt4.Text;
            twoattmpt[3] = twoattempttxt4.Text;
        }

        private void twomadesubbtn4_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt4.Text = "0";
            twomadetxt4.Text = "0";
            twonummade[3] = twonummade[3] - 1;

            twovaluemade[3] = Double.Parse(twomadetxt4.Text) + twonummade[3];
            twovalueattempt[3] = Double.Parse(twoattempttxt4.Text) + twonumattempt1[3] + twovaluemade[3];
            twoattempttxt4.Text = (twovalueattempt[3].ToString());
            twomadetxt4.Text = (twovaluemade[3].ToString());
            twomde[3] = twomadetxt4.Text;
            twoattmpt[3] = twoattempttxt4.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn4_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt4.Text = "0";
            threenumattempt1[3] = threenumattempt1[3] + 1;
            threevalueattempt[3] = Double.Parse(threeattempttxt4.Text) + threenumattempt1[3] + threevaluemade[3];
            threeattempttxt4.Text = (threevalueattempt[3].ToString());
            threeattmpt[3] = threeattempttxt4.Text;

        }

        private void threeattsubbtn4_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt4.Text = "0";
            threenumattempt1[3] = threenumattempt1[3] - 1;
            threevalueattempt[3] = Double.Parse(threeattempttxt4.Text) + threenumattempt1[3] + threevaluemade[3];
            threeattempttxt4.Text = (threevalueattempt[3].ToString());
            threeattmpt[3] = threeattempttxt4.Text;
        }

        private void threemadeaddbtn4_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt4.Text = "0";
            threemadetxt4.Text = "0";
            threenummade[3] = threenummade[3] + 1;

            threevaluemade[3] = Double.Parse(threemadetxt4.Text) + threenummade[3];
            threevalueattempt[3] = Double.Parse(threeattempttxt4.Text) + threenumattempt1[3] + threevaluemade[3];
            threeattempttxt4.Text = (threevalueattempt[3].ToString());
            threemadetxt4.Text = (threevaluemade[3].ToString());
            threemde[3] = threemadetxt4.Text;
            threeattmpt[3] = threeattempttxt4.Text;
        }

        private void threemadesubbtn4_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt4.Text = "0";
            threemadetxt4.Text = "0";
            threenummade[3] = threenummade[3] - 1;

            threevaluemade[3] = Double.Parse(threemadetxt4.Text) + threenummade[3];
            threevalueattempt[3] = Double.Parse(threeattempttxt4.Text) + threenumattempt1[3] + threevaluemade[3];
            threeattempttxt4.Text = (threevalueattempt[3].ToString());
            threemadetxt4.Text = (threevaluemade[3].ToString());
            threemde[3] = threemadetxt4.Text;
            threeattmpt[3] = threeattempttxt4.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn4_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt4.Text = "0";
            foulnumattempt[3] = foulnumattempt[3] + 1;
            foulshotattempt[3] = Double.Parse(flattmpttxt4.Text) + foulnumattempt[3] + foulshotmade[3];

            flattmpttxt4.Text = (foulshotattempt[3].ToString());
            flattmpt[3] = flattmpttxt4.Text;


        }

        private void flattmptsubbtn4_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt4.Text = "0";
            foulnumattempt[3] = foulnumattempt[3] - 1;
            foulshotattempt[3] = Double.Parse(flattmpttxt4.Text) + foulnumattempt[3] + foulshotmade[3];

            flattmpttxt4.Text = (foulshotattempt[3].ToString());
            flattmpt[3] = flattmpttxt4.Text;
        }

        private void flmadeaddbtn4_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt4.Text = "0";
            flamdettxt4.Text = "0";
            foulnummade[3] = foulnummade[3] + 1;

            foulshotmade[3] = Double.Parse(flamdettxt4.Text) + foulnummade[3];
            foulshotattempt[3] = Double.Parse(flattmpttxt4.Text) + foulnumattempt[3] + foulshotmade[3];
            flattmpttxt4.Text = (foulshotattempt[3].ToString());
            flamdettxt4.Text = (foulshotmade[3].ToString());
            flamde[3] = flamdettxt4.Text;
            flattmpt[3] = flattmpttxt4.Text;
        }

        private void flmadesubbtn4_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt4.Text = "0";
            flamdettxt4.Text = "0";
            foulnummade[3] = foulnummade[3] - 1;

            foulshotmade[3] = Double.Parse(flamdettxt4.Text) + foulnummade[3];
            foulshotattempt[3] = Double.Parse(flattmpttxt4.Text) + foulnumattempt[3] + foulshotmade[3];
            flattmpttxt4.Text = (foulshotattempt[3].ToString());
            flamdettxt4.Text = (foulshotmade[3].ToString());
            flamde[3] = flamdettxt4.Text;
            flattmpt[3] = flattmpttxt4.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn4_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt4.Text = "0";
            assistnum[3] = assistnum[3] + 1;

            assistvalue[3] = Double.Parse(assisttxt4.Text) + assistnum[3];
            assisttxt4.Text = (assistvalue[3].ToString());
            assist[3] = assisttxt4.Text;
        }

        private void assistsubbtn4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt4.Text = "0";
            assistnum[3] = assistnum[3] - 1;

            assistvalue[3] = Double.Parse(assisttxt4.Text) + assistnum[3];
            assisttxt4.Text = (assistvalue[3].ToString());
            assist[3] = assisttxt4.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn4_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt4.Text = "0";
            turnovernum[3] = turnovernum[3] + 1;
            turnovervalue[3] = Double.Parse(turnovertxt4.Text) + turnovernum[3];
            turnovertxt4.Text = (turnovervalue[3].ToString());
            turnover[3] = turnovertxt4.Text;
        }

        private void trnvrssubbtn4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt4.Text = "0";
            turnovernum[3] = turnovernum[3] - 1;
            turnovervalue[3] = Double.Parse(turnovertxt4.Text) + turnovernum[3];
            turnovertxt4.Text = (turnovervalue[3].ToString());
            turnover[3] = turnovertxt4.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn4_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt4.Text = "0";
            offrebnum[3] = offrebnum[3] + 1;

            offrebvalue[3] = Double.Parse(offrebtxt4.Text) + offrebnum[3];
            offrebtxt4.Text = (offrebvalue[3].ToString());
            reboff[3] = offrebtxt4.Text;
        }

        private void offsubrebbtn4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt4.Text = "0";
            offrebnum[3] = offrebnum[3] - 1;

            offrebvalue[3] = Double.Parse(offrebtxt4.Text) + offrebnum[3];
            offrebtxt4.Text = (offrebvalue[3].ToString());
            reboff[3] = offrebtxt4.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn4_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt4.Text = "0";
            defrebnum[3] = defrebnum[3] + 1;

            defrebvalue[3] = Double.Parse(defrebtxt4.Text) + defrebnum[3];
            defrebtxt4.Text = (defrebvalue[3].ToString());
            rebdef[3] = defrebtxt4.Text;
        }

        private void defsubrebbtn4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt4.Text = "0";
            defrebnum[3] = defrebnum[3] - 1;

            defrebvalue[3] = Double.Parse(defrebtxt4.Text) + defrebnum[3];
            defrebtxt4.Text = (defrebvalue[3].ToString());
            rebdef[3] = defrebtxt4.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn4_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt4.Text = "0";
            deflectfstnum[3] = deflectfstnum[3] + 1;

            deflectfstvalue[3] = Double.Parse(deflfsttxt4.Text) + deflectfstnum[3];
            deflfsttxt4.Text = (deflectfstvalue[3].ToString());
            deflectfirst[3] = deflfsttxt4.Text;
        }

        private void deflectsubfstbtn4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt4.Text = "0";
            deflectfstnum[3] = deflectfstnum[3] - 1;

            deflectfstvalue[3] = Double.Parse(deflfsttxt4.Text) + deflectfstnum[3];
            deflfsttxt4.Text = (deflectfstvalue[3].ToString());
            deflectfirst[3] = deflfsttxt4.Text;
        }

        private void deflectaddsndbtn4_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt4.Text = "0";
            deflectsndnum[3] = deflectsndnum[3] + 1;

            deflectsndvalue[3] = Double.Parse(deflsndtxt4.Text) + deflectsndnum[3];
            deflsndtxt4.Text = (deflectsndvalue[3].ToString());
            deflectsecond[3] = deflsndtxt4.Text;
        }

        private void deflectsubsndbtn4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt4.Text = "0";
            deflectsndnum[3] = deflectsndnum[3] - 1;

            deflectsndvalue[3] = Double.Parse(deflsndtxt4.Text) + deflectsndnum[3];
            deflsndtxt4.Text = (deflectsndvalue[3].ToString());
            deflectsecond[3] = deflsndtxt4.Text;
        }


        /*-------------------------------------------------------------------- END OF PLAYER4 ------------------------------------------------------------------*/


        /*------------------------------------- Player5 Name------------------------------------------------------------------------------------*/
        private void nametxt5_TextChanged(object sender, EventArgs e)           //Set Fifth player name
        {
            name[4] = nametxt5.Text;
            nametxt5.Text = name[4];
            nametimetxt5.Text = name[4];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn5_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt5.BackColor = Color.LightSalmon;
                twoattempttxt5.BackColor = Color.LightSalmon;
                twomadetxt5.BackColor = Color.LightSalmon;
                threeattempttxt5.BackColor = Color.LightSalmon;
                threemadetxt5.BackColor = Color.LightSalmon;
                flattmpttxt5.BackColor = Color.LightSalmon;
                flamdettxt5.BackColor = Color.LightSalmon;
                assisttxt5.BackColor = Color.LightSalmon;
                turnovertxt5.BackColor = Color.LightSalmon;
                offrebtxt5.BackColor = Color.LightSalmon;
                defrebtxt5.BackColor = Color.LightSalmon;
                deflfsttxt5.BackColor = Color.LightSalmon;
                deflsndtxt5.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt5.BackColor = Color.White;
                twoattempttxt5.BackColor = Color.White;
                twomadetxt5.BackColor = Color.White;
                threeattempttxt5.BackColor = Color.White;
                threemadetxt5.BackColor = Color.White;
                flattmpttxt5.BackColor = Color.White;
                flamdettxt5.BackColor = Color.White;
                assisttxt5.BackColor = Color.White;
                turnovertxt5.BackColor = Color.White;
                offrebtxt5.BackColor = Color.White;
                defrebtxt5.BackColor = Color.White;
                deflfsttxt5.BackColor = Color.White;
                deflsndtxt5.BackColor = Color.White;
                change = true;
            }

        }

        /*------------------------------------- Player5 Number----------------------------------------------------------------------------------*/
        private void textBox5_TextChanged(object sender, EventArgs e)              //set Fifth player number
        {
            number[4] = textBox5.Text;
            textBox5.Text = number[4];
            textBox128.Text = number[4];
            textBox5.Show();
        }

        /*------------------------------------- Player5 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn5_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt5.Text = "0";
            twonumattempt1[4] = twonumattempt1[4] + 1;
            twovalueattempt[4] = Double.Parse(twoattempttxt5.Text) + twonumattempt1[4] + twovaluemade[4];
            twoattempttxt5.Text = (twovalueattempt[4].ToString());
            twoattmpt[4] = twoattempttxt5.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt5_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn5_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt5.Text = "0";
            twonumattempt1[4] = twonumattempt1[4] - 1;
            twovalueattempt[4] = Double.Parse(twoattempttxt5.Text) + twonumattempt1[4] + twovaluemade[4];
            twoattempttxt5.Text = (twovalueattempt[4].ToString());
            twoattmpt[4] = twoattempttxt5.Text;
        }

        private void twomadeaddbtn5_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt5.Text = "0";
            twomadetxt5.Text = "0";
            twonummade[4] = twonummade[4] + 1;

            twovaluemade[4] = Double.Parse(twomadetxt5.Text) + twonummade[4];
            twovalueattempt[4] = Double.Parse(twoattempttxt5.Text) + twonumattempt1[4] + twovaluemade[4];
            twoattempttxt5.Text = (twovalueattempt[4].ToString());
            twomadetxt5.Text = (twovaluemade[4].ToString());
            twomde[4] = twomadetxt5.Text;
        }

        private void twomadesubbtn5_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt5.Text = "0";
            twomadetxt5.Text = "0";
            twonummade[4] = twonummade[4] - 1;

            twovaluemade[4] = Double.Parse(twomadetxt5.Text) + twonummade[4];
            twovalueattempt[4] = Double.Parse(twoattempttxt5.Text) + twonumattempt1[4] + twovaluemade[4];
            twoattempttxt5.Text = (twovalueattempt[4].ToString());
            twomadetxt5.Text = (twovaluemade[4].ToString());
            twomde[4] = twomadetxt5.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn5_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt5.Text = "0";
            threenumattempt1[4] = threenumattempt1[4] + 1;
            threevalueattempt[4] = Double.Parse(threeattempttxt5.Text) + threenumattempt1[4] + threevaluemade[4];
            threeattempttxt5.Text = (threevalueattempt[4].ToString());
            threeattmpt[4] = threeattempttxt5.Text;

        }

        private void threeattsubbtn5_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt5.Text = "0";
            threenumattempt1[4] = threenumattempt1[4] - 1;
            threevalueattempt[4] = Double.Parse(threeattempttxt5.Text) + threenumattempt1[4] + threevaluemade[4];
            threeattempttxt5.Text = (threevalueattempt[4].ToString());
            threeattmpt[4] = threeattempttxt5.Text;
        }

        private void threemadeaddbtn5_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt5.Text = "0";
            threemadetxt5.Text = "0";
            threenummade[4] = threenummade[4] + 1;

            threevaluemade[4] = Double.Parse(threemadetxt5.Text) + threenummade[4];
            threevalueattempt[4] = Double.Parse(threeattempttxt5.Text) + threenumattempt1[4] + threevaluemade[4];
            threeattempttxt5.Text = (threevalueattempt[4].ToString());
            threemadetxt5.Text = (threevaluemade[4].ToString());
            threemde[4] = threemadetxt5.Text;
        }

        private void threemadesubbtn5_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt5.Text = "0";
            threemadetxt5.Text = "0";
            threenummade[4] = threenummade[4] - 1;

            threevaluemade[4] = Double.Parse(threemadetxt5.Text) + threenummade[4];
            threevalueattempt[4] = Double.Parse(threeattempttxt5.Text) + threenumattempt1[4] + threevaluemade[4];
            threeattempttxt5.Text = (threevalueattempt[4].ToString());
            threemadetxt5.Text = (threevaluemade[4].ToString());
            threemde[4] = threemadetxt5.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn5_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt5.Text = "0";
            foulnumattempt[4] = foulnumattempt[4] + 1;
            foulshotattempt[4] = Double.Parse(flattmpttxt5.Text) + foulnumattempt[4] + foulshotmade[4];

            flattmpttxt5.Text = (foulshotattempt[4].ToString());
            flattmpt[4] = flattmpttxt5.Text;


        }

        private void flattmptsubbtn5_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt5.Text = "0";
            foulnumattempt[4] = foulnumattempt[4] - 1;
            foulshotattempt[4] = Double.Parse(flattmpttxt5.Text) + foulnumattempt[4] + foulshotmade[4];

            flattmpttxt5.Text = (foulshotattempt[4].ToString());
            flattmpt[4] = flattmpttxt5.Text;
        }

        private void flmadeaddbtn5_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt5.Text = "0";
            flamdettxt5.Text = "0";
            foulnummade[4] = foulnummade[4] + 1;

            foulshotmade[4] = Double.Parse(flamdettxt5.Text) + foulnummade[4];
            foulshotattempt[4] = Double.Parse(flattmpttxt5.Text) + foulnumattempt[4] + foulshotmade[4];
            flattmpttxt5.Text = (foulshotattempt[4].ToString());
            flamdettxt5.Text = (foulshotmade[4].ToString());
            flamde[4] = flamdettxt5.Text;
        }

        private void flmadesubbtn5_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt5.Text = "0";
            flamdettxt5.Text = "0";
            foulnummade[4] = foulnummade[4] - 1;

            foulshotmade[4] = Double.Parse(flamdettxt5.Text) + foulnummade[4];
            foulshotattempt[4] = Double.Parse(flattmpttxt5.Text) + foulnumattempt[4] + foulshotmade[4];
            flattmpttxt5.Text = (foulshotattempt[4].ToString());
            flamdettxt5.Text = (foulshotmade[4].ToString());
            flamde[4] = flamdettxt5.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn5_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt5.Text = "0";
            assistnum[4] = assistnum[4] + 1;

            assistvalue[4] = Double.Parse(assisttxt5.Text) + assistnum[4];
            assisttxt5.Text = (assistvalue[4].ToString());
            assist[4] = assisttxt5.Text;
        }

        private void assistsubbtn5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt5.Text = "0";
            assistnum[4] = assistnum[4] - 1;

            assistvalue[4] = Double.Parse(assisttxt5.Text) + assistnum[4];
            assisttxt5.Text = (assistvalue[4].ToString());
            assist[4] = assisttxt5.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn5_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt5.Text = "0";
            turnovernum[4] = turnovernum[4] + 1;
            turnovervalue[4] = Double.Parse(turnovertxt5.Text) + turnovernum[4];
            turnovertxt5.Text = (turnovervalue[4].ToString());
            turnover[4] = turnovertxt5.Text;
        }

        private void trnvrssubbtn5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt5.Text = "0";
            turnovernum[4] = turnovernum[4] - 1;
            turnovervalue[4] = Double.Parse(turnovertxt5.Text) + turnovernum[4];
            turnovertxt5.Text = (turnovervalue[4].ToString());
            turnover[4] = turnovertxt5.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn5_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt5.Text = "0";
            offrebnum[4] = offrebnum[4] + 1;

            offrebvalue[4] = Double.Parse(offrebtxt5.Text) + offrebnum[4];
            offrebtxt5.Text = (offrebvalue[4].ToString());
            reboff[4] = offrebtxt5.Text;
        }

        private void offsubrebbtn5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt5.Text = "0";
            offrebnum[4] = offrebnum[4] - 1;

            offrebvalue[4] = Double.Parse(offrebtxt5.Text) + offrebnum[4];
            offrebtxt5.Text = (offrebvalue[4].ToString());
            reboff[4] = offrebtxt5.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn5_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt5.Text = "0";
            defrebnum[4] = defrebnum[4] + 1;

            defrebvalue[4] = Double.Parse(defrebtxt5.Text) + defrebnum[4];
            defrebtxt5.Text = (defrebvalue[4].ToString());
            rebdef[4] = defrebtxt5.Text;
        }

        private void defsubrebbtn5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt5.Text = "0";
            defrebnum[4] = defrebnum[4] - 1;

            defrebvalue[4] = Double.Parse(defrebtxt5.Text) + defrebnum[4];
            defrebtxt5.Text = (defrebvalue[4].ToString());
            rebdef[4] = defrebtxt5.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn5_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt5.Text = "0";
            deflectfstnum[4] = deflectfstnum[4] + 1;

            deflectfstvalue[4] = Double.Parse(deflfsttxt5.Text) + deflectfstnum[4];
            deflfsttxt5.Text = (deflectfstvalue[4].ToString());
            deflectfirst[4] = deflfsttxt5.Text;
        }

        private void deflectsubfstbtn5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt5.Text = "0";
            deflectfstnum[4] = deflectfstnum[4] - 1;

            deflectfstvalue[4] = Double.Parse(deflfsttxt5.Text) + deflectfstnum[4];
            deflfsttxt5.Text = (deflectfstvalue[4].ToString());
            deflectfirst[4] = deflfsttxt5.Text;
        }

        private void deflectaddsndbtn5_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt5.Text = "0";
            deflectsndnum[4] = deflectsndnum[4] + 1;

            deflectsndvalue[4] = Double.Parse(deflsndtxt5.Text) + deflectsndnum[4];
            deflsndtxt5.Text = (deflectsndvalue[4].ToString());
            deflectsecond[4] = deflsndtxt5.Text;
        }

        private void deflectsubsndbtn5_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt5.Text = "0";
            deflectsndnum[4] = deflectsndnum[4] - 1;

            deflectsndvalue[4] = Double.Parse(deflsndtxt5.Text) + deflectsndnum[4];
            deflsndtxt5.Text = (deflectsndvalue[4].ToString());
            deflectsecond[4] = deflsndtxt5.Text;
        }
        /*-------------------------------------------------------------------- END OF PLAYER5 ------------------------------------------------------------------*/

        /*------------------------------------- Player6 Name------------------------------------------------------------------------------------*/
        private void nametxt6_TextChanged(object sender, EventArgs e)           //Set Sixth player name
        {
            name[5] = nametxt6.Text;
            nametxt6.Text = name[5];
            nametimetxt6.Text = name[5];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn6_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt6.BackColor = Color.LightSalmon;
                twoattempttxt6.BackColor = Color.LightSalmon;
                twomadetxt6.BackColor = Color.LightSalmon;
                threeattempttxt6.BackColor = Color.LightSalmon;
                threemadetxt6.BackColor = Color.LightSalmon;
                flattmpttxt6.BackColor = Color.LightSalmon;
                flamdettxt6.BackColor = Color.LightSalmon;
                assisttxt6.BackColor = Color.LightSalmon;
                turnovertxt6.BackColor = Color.LightSalmon;
                offrebtxt6.BackColor = Color.LightSalmon;
                defrebtxt6.BackColor = Color.LightSalmon;
                deflfsttxt6.BackColor = Color.LightSalmon;
                deflsndtxt6.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt6.BackColor = Color.White;
                twoattempttxt6.BackColor = Color.White;
                twomadetxt6.BackColor = Color.White;
                threeattempttxt6.BackColor = Color.White;
                threemadetxt6.BackColor = Color.White;
                flattmpttxt6.BackColor = Color.White;
                flamdettxt6.BackColor = Color.White;
                assisttxt6.BackColor = Color.White;
                turnovertxt6.BackColor = Color.White;
                offrebtxt6.BackColor = Color.White;
                defrebtxt6.BackColor = Color.White;
                deflfsttxt6.BackColor = Color.White;
                deflsndtxt6.BackColor = Color.White;
                change = true;
            }

        }
        /*------------------------------------- Player2 Number----------------------------------------------------------------------------------*/
        private void textBox6_TextChanged(object sender, EventArgs e)              //set Sixth player number
        {
            number[5] = textBox6.Text;
            textBox6.Text = number[5];
            textBox127.Text = number[5];
            textBox6.Show();
        }

        /*------------------------------------- Player2 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn6_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt6.Text = "0";
            twonumattempt1[5] = twonumattempt1[5] + 1;
            twovalueattempt[5] = Double.Parse(twoattempttxt6.Text) + twonumattempt1[5] + twovaluemade[5];
            twoattempttxt6.Text = (twovalueattempt[5].ToString());
            twoattmpt[5] = twoattempttxt6.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt6_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn6_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt6.Text = "0";
            twonumattempt1[5] = twonumattempt1[5] - 1;
            twovalueattempt[5] = Double.Parse(twoattempttxt6.Text) + twonumattempt1[5] + twovaluemade[5];
            twoattempttxt6.Text = (twovalueattempt[5].ToString());
            twoattmpt[5] = twoattempttxt6.Text;
        }

        private void twomadeaddbtn6_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt6.Text = "0";
            twomadetxt6.Text = "0";
            twonummade[5] = twonummade[5] + 1;

            twovaluemade[5] = Double.Parse(twomadetxt6.Text) + twonummade[5];
            twovalueattempt[5] = Double.Parse(twoattempttxt6.Text) + twonumattempt1[5] + twovaluemade[5];
            twoattempttxt6.Text = (twovalueattempt[5].ToString());
            twomadetxt6.Text = (twovaluemade[5].ToString());
            twomde[5] = twomadetxt6.Text;
        }

        private void twomadesubbtn6_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt6.Text = "0";
            twomadetxt6.Text = "0";
            twonummade[5] = twonummade[5] - 1;

            twovaluemade[5] = Double.Parse(twomadetxt6.Text) + twonummade[5];
            twovalueattempt[5] = Double.Parse(twoattempttxt6.Text) + twonumattempt1[5] + twovaluemade[5];
            twoattempttxt6.Text = (twovalueattempt[5].ToString());
            twomadetxt6.Text = (twovaluemade[5].ToString());
            twomde[5] = twomadetxt6.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn6_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt6.Text = "0";
            threenumattempt1[5] = threenumattempt1[5] + 1;
            threevalueattempt[5] = Double.Parse(threeattempttxt6.Text) + threenumattempt1[5] + threevaluemade[5];
            threeattempttxt6.Text = (threevalueattempt[5].ToString());
            threeattmpt[5] = threeattempttxt6.Text;

        }

        private void threeattsubbtn6_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt6.Text = "0";
            threenumattempt1[5] = threenumattempt1[5] - 1;
            threevalueattempt[5] = Double.Parse(threeattempttxt6.Text) + threenumattempt1[5] + threevaluemade[5];
            threeattempttxt6.Text = (threevalueattempt[5].ToString());
            threeattmpt[5] = threeattempttxt6.Text;
        }

        private void threemadeaddbtn6_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt6.Text = "0";
            threemadetxt6.Text = "0";
            threenummade[5] = threenummade[5] + 1;

            threevaluemade[5] = Double.Parse(threemadetxt6.Text) + threenummade[5];
            threevalueattempt[5] = Double.Parse(threeattempttxt6.Text) + threenumattempt1[5] + threevaluemade[5];
            threeattempttxt6.Text = (threevalueattempt[5].ToString());
            threemadetxt6.Text = (threevaluemade[5].ToString());
            threemde[5] = threemadetxt6.Text;
        }

        private void threemadesubbtn6_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt6.Text = "0";
            threemadetxt6.Text = "0";
            threenummade[5] = threenummade[5] - 1;

            threevaluemade[5] = Double.Parse(threemadetxt6.Text) + threenummade[5];
            threevalueattempt[5] = Double.Parse(threeattempttxt6.Text) + threenumattempt1[5] + threevaluemade[5];
            threeattempttxt6.Text = (threevalueattempt[5].ToString());
            threemadetxt6.Text = (threevaluemade[5].ToString());
            threemde[5] = threemadetxt6.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn6_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt6.Text = "0";
            foulnumattempt[5] = foulnumattempt[5] + 1;
            foulshotattempt[5] = Double.Parse(flattmpttxt6.Text) + foulnumattempt[5] + foulshotmade[5];

            flattmpttxt6.Text = (foulshotattempt[5].ToString());
            flattmpt[5] = flattmpttxt6.Text;


        }

        private void flattmptsubbtn6_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt6.Text = "0";
            foulnumattempt[5] = foulnumattempt[5] - 1;
            foulshotattempt[5] = Double.Parse(flattmpttxt6.Text) + foulnumattempt[5] + foulshotmade[5];

            flattmpttxt6.Text = (foulshotattempt[5].ToString());
            flattmpt[5] = flattmpttxt6.Text;
        }

        private void flmadeaddbtn6_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt6.Text = "0";
            flamdettxt6.Text = "0";
            foulnummade[5] = foulnummade[5] + 1;

            foulshotmade[5] = Double.Parse(flamdettxt6.Text) + foulnummade[5];
            foulshotattempt[5] = Double.Parse(flattmpttxt6.Text) + foulnumattempt[5] + foulshotmade[5];
            flattmpttxt6.Text = (foulshotattempt[5].ToString());
            flamdettxt6.Text = (foulshotmade[5].ToString());
            flamde[5] = flamdettxt6.Text;
            flattmpt[5] = flattmpttxt6.Text;
        }

        private void flmadesubbtn6_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt6.Text = "0";
            flamdettxt6.Text = "0";
            foulnummade[5] = foulnummade[5] - 1;

            foulshotmade[5] = Double.Parse(flamdettxt6.Text) + foulnummade[5];
            foulshotattempt[5] = Double.Parse(flattmpttxt6.Text) + foulnumattempt[5] + foulshotmade[5];
            flattmpttxt6.Text = (foulshotattempt[5].ToString());
            flamdettxt6.Text = (foulshotmade[5].ToString());
            flamde[5] = flamdettxt6.Text;
            flattmpt[5] = flattmpttxt6.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn6_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt6.Text = "0";
            assistnum[5] = assistnum[5] + 1;

            assistvalue[5] = Double.Parse(assisttxt6.Text) + assistnum[5];
            assisttxt6.Text = (assistvalue[5].ToString());
            assist[5] = assisttxt6.Text;
        }

        private void assistsubbtn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt6.Text = "0";
            assistnum[5] = assistnum[5] - 1;

            assistvalue[5] = Double.Parse(assisttxt6.Text) + assistnum[5];
            assisttxt6.Text = (assistvalue[5].ToString());
            assist[5] = assisttxt6.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn6_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt6.Text = "0";
            turnovernum[5] = turnovernum[5] + 1;
            turnovervalue[5] = Double.Parse(turnovertxt6.Text) + turnovernum[5];
            turnovertxt6.Text = (turnovervalue[5].ToString());
            turnover[5] = turnovertxt6.Text;
        }

        private void trnvrssubbtn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt6.Text = "0";
            turnovernum[5] = turnovernum[5] - 1;
            turnovervalue[5] = Double.Parse(turnovertxt6.Text) + turnovernum[5];
            turnovertxt6.Text = (turnovervalue[5].ToString());
            turnover[5] = turnovertxt6.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn6_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt6.Text = "0";
            offrebnum[5] = offrebnum[5] + 1;

            offrebvalue[5] = Double.Parse(offrebtxt6.Text) + offrebnum[5];
            offrebtxt6.Text = (offrebvalue[5].ToString());
            reboff[5] = offrebtxt6.Text;
        }

        private void offsubrebbtn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt6.Text = "0";
            offrebnum[5] = offrebnum[5] - 1;

            offrebvalue[5] = Double.Parse(offrebtxt6.Text) + offrebnum[5];
            offrebtxt6.Text = (offrebvalue[5].ToString());
            reboff[5] = offrebtxt6.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn6_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt6.Text = "0";
            defrebnum[5] = defrebnum[5] + 1;

            defrebvalue[5] = Double.Parse(defrebtxt6.Text) + defrebnum[5];
            defrebtxt6.Text = (defrebvalue[5].ToString());
            rebdef[5] = defrebtxt6.Text;
        }

        private void defsubrebbtn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt6.Text = "0";
            defrebnum[5] = defrebnum[5] - 1;

            defrebvalue[5] = Double.Parse(defrebtxt6.Text) + defrebnum[5];
            defrebtxt6.Text = (defrebvalue[5].ToString());
            rebdef[5] = defrebtxt6.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn6_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt6.Text = "0";
            deflectfstnum[5] = deflectfstnum[5] + 1;

            deflectfstvalue[5] = Double.Parse(deflfsttxt6.Text) + deflectfstnum[5];
            deflfsttxt6.Text = (deflectfstvalue[5].ToString());
            deflectfirst[5] = deflfsttxt6.Text;
        }

        private void deflectsubfstbtn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt6.Text = "0";
            deflectfstnum[5] = deflectfstnum[5] - 1;

            deflectfstvalue[5] = Double.Parse(deflfsttxt6.Text) + deflectfstnum[5];
            deflfsttxt6.Text = (deflectfstvalue[5].ToString());
            deflectfirst[5] = deflfsttxt6.Text;
        }

        private void deflectaddsndbtn6_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt6.Text = "0";
            deflectsndnum[5] = deflectsndnum[5] + 1;

            deflectsndvalue[5] = Double.Parse(deflsndtxt6.Text) + deflectsndnum[5];
            deflsndtxt6.Text = (deflectsndvalue[5].ToString());
            deflectsecond[5] = deflsndtxt6.Text;
        }

        private void deflectsubsndbtn6_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt6.Text = "0";
            deflectsndnum[5] = deflectsndnum[5] - 1;

            deflectsndvalue[5] = Double.Parse(deflsndtxt6.Text) + deflectsndnum[5];
            deflsndtxt6.Text = (deflectsndvalue[5].ToString());
            deflectsecond[5] = deflsndtxt6.Text;
        }

 
        /*-------------------------------------------------------------------- END OF PLAYER6 ------------------------------------------------------------------*/

        /*------------------------------------- Player7 Name------------------------------------------------------------------------------------*/
        private void nametxt7_TextChanged(object sender, EventArgs e)           //Set Seventh player name
        {
            name[6] = nametxt7.Text;
            nametxt7.Text = name[6];
            nametimetxt7.Text = name[6];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn7_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt7.BackColor = Color.LightSalmon;
                twoattempttxt7.BackColor = Color.LightSalmon;
                twomadetxt7.BackColor = Color.LightSalmon;
                threeattempttxt7.BackColor = Color.LightSalmon;
                threemadetxt7.BackColor = Color.LightSalmon;
                flattmpttxt7.BackColor = Color.LightSalmon;
                flamdettxt7.BackColor = Color.LightSalmon;
                assisttxt7.BackColor = Color.LightSalmon;
                turnovertxt7.BackColor = Color.LightSalmon;
                offrebtxt7.BackColor = Color.LightSalmon;
                defrebtxt7.BackColor = Color.LightSalmon;
                deflfsttxt7.BackColor = Color.LightSalmon;
                deflsndtxt7.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt7.BackColor = Color.White;
                twoattempttxt7.BackColor = Color.White;
                twomadetxt7.BackColor = Color.White;
                threeattempttxt7.BackColor = Color.White;
                threemadetxt7.BackColor = Color.White;
                flattmpttxt7.BackColor = Color.White;
                flamdettxt7.BackColor = Color.White;
                assisttxt7.BackColor = Color.White;
                turnovertxt7.BackColor = Color.White;
                offrebtxt7.BackColor = Color.White;
                defrebtxt7.BackColor = Color.White;
                deflfsttxt7.BackColor = Color.White;
                deflsndtxt7.BackColor = Color.White;
                change = true;
            }

        }
        /*------------------------------------- Player7 Number----------------------------------------------------------------------------------*/
        private void textBox7_TextChanged(object sender, EventArgs e)              //set Seventh player number
        {
            number[6] = textBox7.Text;
            textBox7.Text = number[6];
            textBox125.Text = number[6];
            textBox7.Show();
        }

        /*------------------------------------- Player7 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn7_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt7.Text = "0";
            twonumattempt1[6] = twonumattempt1[6] + 1;
            twovalueattempt[6] = Double.Parse(twoattempttxt7.Text) + twonumattempt1[6] + twovaluemade[6];
            twoattempttxt7.Text = (twovalueattempt[6].ToString());
            twoattmpt[6] = twoattempttxt7.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt7_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn7_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt7.Text = "0";
            twonumattempt1[6] = twonumattempt1[6] - 1;
            twovalueattempt[6] = Double.Parse(twoattempttxt7.Text) + twonumattempt1[6] + twovaluemade[6];
            twoattempttxt7.Text = (twovalueattempt[6].ToString());
            twoattmpt[6] = twoattempttxt7.Text;
        }

        private void twomadeaddbtn7_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt7.Text = "0";
            twomadetxt7.Text = "0";
            twonummade[6] = twonummade[6] + 1;

            twovaluemade[6] = Double.Parse(twomadetxt7.Text) + twonummade[6];
            twovalueattempt[6] = Double.Parse(twoattempttxt7.Text) + twonumattempt1[6] + twovaluemade[6];
            twoattempttxt7.Text = (twovalueattempt[6].ToString());
            twomadetxt7.Text = (twovaluemade[6].ToString());
            twomde[6] = twomadetxt7.Text;
        }

        private void twomadesubbtn7_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt7.Text = "0";
            twomadetxt7.Text = "0";
            twonummade[6] = twonummade[6] - 1;

            twovaluemade[6] = Double.Parse(twomadetxt7.Text) + twonummade[6];
            twovalueattempt[6] = Double.Parse(twoattempttxt7.Text) + twonumattempt1[6] + twovaluemade[6];
            twoattempttxt7.Text = (twovalueattempt[6].ToString());
            twomadetxt7.Text = (twovaluemade[6].ToString());
            twomde[6] = twomadetxt7.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn7_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt7.Text = "0";
            threenumattempt1[6] = threenumattempt1[6] + 1;
            threevalueattempt[6] = Double.Parse(threeattempttxt7.Text) + threenumattempt1[6] + threevaluemade[6];
            threeattempttxt7.Text = (threevalueattempt[6].ToString());
            threeattmpt[6] = threeattempttxt7.Text;

        }

        private void threeattsubbtn7_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt7.Text = "0";
            threenumattempt1[6] = threenumattempt1[6] - 1;
            threevalueattempt[6] = Double.Parse(threeattempttxt7.Text) + threenumattempt1[6] + threevaluemade[6];
            threeattempttxt7.Text = (threevalueattempt[6].ToString());
            threeattmpt[6] = threeattempttxt7.Text;
        }

        private void threemadeaddbtn7_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt7.Text = "0";
            threemadetxt7.Text = "0";
            threenummade[6] = threenummade[6] + 1;

            threevaluemade[6] = Double.Parse(threemadetxt7.Text) + threenummade[6];
            threevalueattempt[6] = Double.Parse(threeattempttxt7.Text) + threenumattempt1[6] + threevaluemade[6];
            threeattempttxt7.Text = (threevalueattempt[6].ToString());
            threemadetxt7.Text = (threevaluemade[6].ToString());
            threemde[6] = threemadetxt7.Text;
        }

        private void threemadesubbtn7_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt7.Text = "0";
            threemadetxt7.Text = "0";
            threenummade[6] = threenummade[6] - 1;

            threevaluemade[6] = Double.Parse(threemadetxt7.Text) + threenummade[6];
            threevalueattempt[6] = Double.Parse(threeattempttxt7.Text) + threenumattempt1[6] + threevaluemade[6];
            threeattempttxt7.Text = (threevalueattempt[6].ToString());
            threemadetxt7.Text = (threevaluemade[6].ToString());
            threemde[6] = threemadetxt7.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn7_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt7.Text = "0";
            foulnumattempt[6] = foulnumattempt[6] + 1;
            foulshotattempt[6] = Double.Parse(flattmpttxt7.Text) + foulnumattempt[6] + foulshotmade[6];

            flattmpttxt7.Text = (foulshotattempt[6].ToString());
            flattmpt[6] = flattmpttxt7.Text;


        }

        private void flattmptsubbtn7_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt7.Text = "0";
            foulnumattempt[6] = foulnumattempt[6] - 1;
            foulshotattempt[6] = Double.Parse(flattmpttxt7.Text) + foulnumattempt[6] + foulshotmade[6];

            flattmpttxt7.Text = (foulshotattempt[6].ToString());
            flattmpt[6] = flattmpttxt7.Text;
        }

        private void flmadeaddbtn7_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt7.Text = "0";
            flamdettxt7.Text = "0";
            foulnummade[6] = foulnummade[6] + 1;

            foulshotmade[6] = Double.Parse(flamdettxt7.Text) + foulnummade[6];
            foulshotattempt[6] = Double.Parse(flattmpttxt7.Text) + foulnumattempt[6] + foulshotmade[6];
            flattmpttxt7.Text = (foulshotattempt[6].ToString());
            flamdettxt7.Text = (foulshotmade[6].ToString());
            flamde[6] = flamdettxt7.Text;
        }

        private void flmadesubbtn7_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt7.Text = "0";
            flamdettxt7.Text = "0";
            foulnummade[6] = foulnummade[6] - 1;

            foulshotmade[6] = Double.Parse(flamdettxt7.Text) + foulnummade[6];
            foulshotattempt[6] = Double.Parse(flattmpttxt7.Text) + foulnumattempt[6] + foulshotmade[6];
            flattmpttxt7.Text = (foulshotattempt[6].ToString());
            flamdettxt7.Text = (foulshotmade[6].ToString());
            flamde[6] = flamdettxt7.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn7_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt7.Text = "0";
            assistnum[6] = assistnum[6] + 1;

            assistvalue[6] = Double.Parse(assisttxt7.Text) + assistnum[6];
            assisttxt7.Text = (assistvalue[6].ToString());
            assist[6] = assisttxt7.Text;
        }

        private void assistsubbtn7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt7.Text = "0";
            assistnum[6] = assistnum[6] - 1;

            assistvalue[6] = Double.Parse(assisttxt7.Text) + assistnum[6];
            assisttxt7.Text = (assistvalue[6].ToString());
            assist[6] = assisttxt7.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn7_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt7.Text = "0";
            turnovernum[6] = turnovernum[6] + 1;
            turnovervalue[6] = Double.Parse(turnovertxt7.Text) + turnovernum[6];
            turnovertxt7.Text = (turnovervalue[6].ToString());
            turnover[6] = turnovertxt7.Text;
        }

        private void trnvrssubbtn7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt7.Text = "0";
            turnovernum[6] = turnovernum[6] - 1;
            turnovervalue[6] = Double.Parse(turnovertxt7.Text) + turnovernum[6];
            turnovertxt7.Text = (turnovervalue[6].ToString());
            turnover[6] = turnovertxt7.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn7_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt7.Text = "0";
            offrebnum[6] = offrebnum[6] + 1;

            offrebvalue[6] = Double.Parse(offrebtxt7.Text) + offrebnum[6];
            offrebtxt7.Text = (offrebvalue[6].ToString());
            reboff[6] = offrebtxt7.Text;
        }

        private void offsubrebbtn7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt7.Text = "0";
            offrebnum[6] = offrebnum[6] - 1;

            offrebvalue[6] = Double.Parse(offrebtxt7.Text) + offrebnum[6];
            offrebtxt7.Text = (offrebvalue[6].ToString());
            reboff[6] = offrebtxt7.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn7_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt7.Text = "0";
            defrebnum[6] = defrebnum[6] + 1;

            defrebvalue[6] = Double.Parse(defrebtxt7.Text) + defrebnum[6];
            defrebtxt7.Text = (defrebvalue[6].ToString());
            rebdef[6] = defrebtxt7.Text;
        }

        private void defsubrebbtn7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt7.Text = "0";
            defrebnum[6] = defrebnum[6] - 1;

            defrebvalue[6] = Double.Parse(defrebtxt7.Text) + defrebnum[6];
            defrebtxt7.Text = (defrebvalue[6].ToString());
            rebdef[6] = defrebtxt7.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn7_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt7.Text = "0";
            deflectfstnum[6] = deflectfstnum[6] + 1;

            deflectfstvalue[6] = Double.Parse(deflfsttxt7.Text) + deflectfstnum[6];
            deflfsttxt7.Text = (deflectfstvalue[6].ToString());
            deflectfirst[6] = deflfsttxt7.Text;
        }

        private void deflectsubfstbtn7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt7.Text = "0";
            deflectfstnum[6] = deflectfstnum[6] - 1;

            deflectfstvalue[6] = Double.Parse(deflfsttxt7.Text) + deflectfstnum[6];
            deflfsttxt7.Text = (deflectfstvalue[6].ToString());
            deflectfirst[6] = deflfsttxt7.Text;
        }

        private void deflectaddsndbtn7_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt7.Text = "0";
            deflectsndnum[6] = deflectsndnum[6] + 1;

            deflectsndvalue[6] = Double.Parse(deflsndtxt7.Text) + deflectsndnum[6];
            deflsndtxt7.Text = (deflectsndvalue[6].ToString());
            deflectsecond[6] = deflsndtxt7.Text;
        }

        private void deflectsubsndbtn7_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt7.Text = "0";
            deflectsndnum[6] = deflectsndnum[6] - 1;

            deflectsndvalue[6] = Double.Parse(deflsndtxt7.Text) + deflectsndnum[6];
            deflsndtxt7.Text = (deflectsndvalue[6].ToString());
            deflectsecond[6] = deflsndtxt7.Text;
        }
        /*-------------------------------------------------------------------- END OF PLAYER7 ------------------------------------------------------------------*/

        /*------------------------------------- Player8 Name------------------------------------------------------------------------------------*/
        private void nametxt8_TextChanged(object sender, EventArgs e)           //Set Eighth player name
        {
            name[7] = nametxt8.Text;
            nametxt8.Text = name[7];
            nametimetxt8.Text = name[7];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn8_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt8.BackColor = Color.LightSalmon;
                twoattempttxt8.BackColor = Color.LightSalmon;
                twomadetxt8.BackColor = Color.LightSalmon;
                threeattempttxt8.BackColor = Color.LightSalmon;
                threemadetxt8.BackColor = Color.LightSalmon;
                flattmpttxt8.BackColor = Color.LightSalmon;
                flamdettxt8.BackColor = Color.LightSalmon;
                assisttxt8.BackColor = Color.LightSalmon;
                turnovertxt8.BackColor = Color.LightSalmon;
                offrebtxt8.BackColor = Color.LightSalmon;
                defrebtxt8.BackColor = Color.LightSalmon;
                deflfsttxt8.BackColor = Color.LightSalmon;
                deflsndtxt8.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt8.BackColor = Color.White;
                twoattempttxt8.BackColor = Color.White;
                twomadetxt8.BackColor = Color.White;
                threeattempttxt8.BackColor = Color.White;
                threemadetxt8.BackColor = Color.White;
                flattmpttxt8.BackColor = Color.White;
                flamdettxt8.BackColor = Color.White;
                assisttxt8.BackColor = Color.White;
                turnovertxt8.BackColor = Color.White;
                offrebtxt8.BackColor = Color.White;
                defrebtxt8.BackColor = Color.White;
                deflfsttxt8.BackColor = Color.White;
                deflsndtxt8.BackColor = Color.White;
                change = true;
            }

        }
        /*------------------------------------- Player8 Number----------------------------------------------------------------------------------*/
        private void textBox8_TextChanged(object sender, EventArgs e)              //set Eighth player number
        {
            number[7] = textBox8.Text;
            textBox8.Text = number[7];
            textBox123.Text = number[7];
            textBox8.Show();
        }

        /*------------------------------------- Player8 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn8_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt8.Text = "0";
            twonumattempt1[7] = twonumattempt1[7] + 1;
            twovalueattempt[7] = Double.Parse(twoattempttxt8.Text) + twonumattempt1[7] + twovaluemade[7];
            twoattempttxt8.Text = (twovalueattempt[7].ToString());
            twoattmpt[7] = twoattempttxt8.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt8_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn8_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt8.Text = "0";
            twonumattempt1[7] = twonumattempt1[7] - 1;
            twovalueattempt[7] = Double.Parse(twoattempttxt8.Text) + twonumattempt1[7] + twovaluemade[7];
            twoattempttxt8.Text = (twovalueattempt[7].ToString());
            twoattmpt[7] = twoattempttxt8.Text;
        }

        private void twomadeaddbtn8_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt8.Text = "0";
            twomadetxt8.Text = "0";
            twonummade[7] = twonummade[7] + 1;

            twovaluemade[7] = Double.Parse(twomadetxt8.Text) + twonummade[7];
            twovalueattempt[7] = Double.Parse(twoattempttxt8.Text) + twonumattempt1[7] + twovaluemade[7];
            twoattempttxt8.Text = (twovalueattempt[7].ToString());
            twomadetxt8.Text = (twovaluemade[7].ToString());
            twomde[7] = twomadetxt8.Text;
        }

        private void twomadesubbtn8_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt8.Text = "0";
            twomadetxt8.Text = "0";
            twonummade[7] = twonummade[7] - 1;

            twovaluemade[7] = Double.Parse(twomadetxt8.Text) + twonummade[7];
            twovalueattempt[7] = Double.Parse(twoattempttxt8.Text) + twonumattempt1[7] + twovaluemade[7];
            twoattempttxt8.Text = (twovalueattempt[7].ToString());
            twomadetxt8.Text = (twovaluemade[7].ToString());
            twomde[7] = twomadetxt8.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn8_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt8.Text = "0";
            threenumattempt1[7] = threenumattempt1[7] + 1;
            threevalueattempt[7] = Double.Parse(threeattempttxt8.Text) + threenumattempt1[7] + threevaluemade[7];
            threeattempttxt8.Text = (threevalueattempt[7].ToString());
            threeattmpt[7] = threeattempttxt8.Text;

        }

        private void threeattsubbtn8_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt8.Text = "0";
            threenumattempt1[7] = threenumattempt1[7] - 1;
            threevalueattempt[7] = Double.Parse(threeattempttxt8.Text) + threenumattempt1[7] + threevaluemade[7];
            threeattempttxt8.Text = (threevalueattempt[7].ToString());
            threeattmpt[7] = threeattempttxt8.Text;
        }

        private void threemadeaddbtn8_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt8.Text = "0";
            threemadetxt8.Text = "0";
            threenummade[7] = threenummade[7] + 1;

            threevaluemade[7] = Double.Parse(threemadetxt8.Text) + threenummade[7];
            threevalueattempt[7] = Double.Parse(threeattempttxt8.Text) + threenumattempt1[7] + threevaluemade[7];
            threeattempttxt8.Text = (threevalueattempt[7].ToString());
            threemadetxt8.Text = (threevaluemade[7].ToString());
            threemde[7] = threemadetxt8.Text;
        }

        private void threemadesubbtn8_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt8.Text = "0";
            threemadetxt8.Text = "0";
            threenummade[7] = threenummade[7] - 1;

            threevaluemade[7] = Double.Parse(threemadetxt8.Text) + threenummade[7];
            threevalueattempt[7] = Double.Parse(threeattempttxt8.Text) + threenumattempt1[7] + threevaluemade[7];
            threeattempttxt8.Text = (threevalueattempt[7].ToString());
            threemadetxt8.Text = (threevaluemade[7].ToString());
            threemde[7] = threemadetxt8.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn8_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt8.Text = "0";
            foulnumattempt[7] = foulnumattempt[7] + 1;
            foulshotattempt[7] = Double.Parse(flattmpttxt8.Text) + foulnumattempt[7] + foulshotmade[7];

            flattmpttxt8.Text = (foulshotattempt[7].ToString());
            flattmpt[7] = flattmpttxt8.Text;


        }

        private void flattmptsubbtn8_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt8.Text = "0";
            foulnumattempt[7] = foulnumattempt[7] - 1;
            foulshotattempt[7] = Double.Parse(flattmpttxt8.Text) + foulnumattempt[7] + foulshotmade[7];

            flattmpttxt8.Text = (foulshotattempt[7].ToString());
            flattmpt[7] = flattmpttxt8.Text;
        }

        private void flmadeaddbtn8_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt8.Text = "0";
            flamdettxt8.Text = "0";
            foulnummade[7] = foulnummade[7] + 1;

            foulshotmade[7] = Double.Parse(flamdettxt8.Text) + foulnummade[7];
            foulshotattempt[7] = Double.Parse(flattmpttxt8.Text) + foulnumattempt[7] + foulshotmade[7];
            flattmpttxt8.Text = (foulshotattempt[7].ToString());
            flamdettxt8.Text = (foulshotmade[7].ToString());
            flamde[7] = flamdettxt8.Text;
            flattmpt[7] = flattmpttxt8.Text;
        }

        private void flmadesubbtn8_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt8.Text = "0";
            flamdettxt8.Text = "0";
            foulnummade[7] = foulnummade[7] - 1;

            foulshotmade[7] = Double.Parse(flamdettxt8.Text) + foulnummade[7];
            foulshotattempt[7] = Double.Parse(flattmpttxt8.Text) + foulnumattempt[7] + foulshotmade[7];
            flattmpttxt8.Text = (foulshotattempt[7].ToString());
            flamdettxt8.Text = (foulshotmade[7].ToString());
            flamde[7] = flamdettxt8.Text;
            flattmpt[7] = flattmpttxt8.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn8_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt8.Text = "0";
            assistnum[7] = assistnum[7] + 1;

            assistvalue[7] = Double.Parse(assisttxt8.Text) + assistnum[7];
            assisttxt8.Text = (assistvalue[7].ToString());
            assist[7] = assisttxt8.Text;
        }

        private void assistsubbtn8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt8.Text = "0";
            assistnum[7] = assistnum[7] - 1;

            assistvalue[7] = Double.Parse(assisttxt8.Text) + assistnum[7];
            assisttxt8.Text = (assistvalue[7].ToString());
            assist[7] = assisttxt8.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn8_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt8.Text = "0";
            turnovernum[7] = turnovernum[7] + 1;
            turnovervalue[7] = Double.Parse(turnovertxt8.Text) + turnovernum[7];
            turnovertxt8.Text = (turnovervalue[7].ToString());
            turnover[7] = turnovertxt8.Text;
        }

        private void trnvrssubbtn8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt8.Text = "0";
            turnovernum[7] = turnovernum[7] - 1;
            turnovervalue[7] = Double.Parse(turnovertxt8.Text) + turnovernum[7];
            turnovertxt8.Text = (turnovervalue[7].ToString());
            turnover[7] = turnovertxt8.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn8_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt8.Text = "0";
            offrebnum[7] = offrebnum[7] + 1;

            offrebvalue[7] = Double.Parse(offrebtxt8.Text) + offrebnum[7];
            offrebtxt8.Text = (offrebvalue[7].ToString());
            reboff[7] = offrebtxt8.Text;
        }

        private void offsubrebbtn8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt8.Text = "0";
            offrebnum[7] = offrebnum[7] - 1;

            offrebvalue[7] = Double.Parse(offrebtxt8.Text) + offrebnum[7];
            offrebtxt8.Text = (offrebvalue[7].ToString());
            reboff[7] = offrebtxt8.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn8_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt8.Text = "0";
            defrebnum[7] = defrebnum[7] + 1;

            defrebvalue[7] = Double.Parse(defrebtxt8.Text) + defrebnum[7];
            defrebtxt8.Text = (defrebvalue[7].ToString());
            rebdef[7] = defrebtxt8.Text;
        }

        private void defsubrebbtn8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt8.Text = "0";
            defrebnum[7] = defrebnum[7] - 1;

            defrebvalue[7] = Double.Parse(defrebtxt8.Text) + defrebnum[7];
            defrebtxt8.Text = (defrebvalue[7].ToString());
            rebdef[7] = defrebtxt8.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn8_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt8.Text = "0";
            deflectfstnum[7] = deflectfstnum[7] + 1;

            deflectfstvalue[7] = Double.Parse(deflfsttxt8.Text) + deflectfstnum[7];
            deflfsttxt8.Text = (deflectfstvalue[7].ToString());
            deflectfirst[7] = deflfsttxt8.Text;
        }

        private void deflectsubfstbtn8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt8.Text = "0";
            deflectfstnum[7] = deflectfstnum[7] - 1;

            deflectfstvalue[7] = Double.Parse(deflfsttxt8.Text) + deflectfstnum[7];
            deflfsttxt8.Text = (deflectfstvalue[7].ToString());
            deflectfirst[7] = deflfsttxt8.Text;
        }

        private void deflectaddsndbtn8_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt8.Text = "0";
            deflectsndnum[7] = deflectsndnum[7] + 1;

            deflectsndvalue[7] = Double.Parse(deflsndtxt8.Text) + deflectsndnum[7];
            deflsndtxt8.Text = (deflectsndvalue[7].ToString());
            deflectsecond[7] = deflsndtxt8.Text;
        }

        private void deflectsubsndbtn8_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt8.Text = "0";
            deflectsndnum[7] = deflectsndnum[7] - 1;

            deflectsndvalue[7] = Double.Parse(deflsndtxt8.Text) + deflectsndnum[7];
            deflsndtxt8.Text = (deflectsndvalue[7].ToString());
            deflectsecond[7] = deflsndtxt8.Text;
        }

     
        /*-------------------------------------------------------------------- END OF PLAYER8 ------------------------------------------------------------------*/


        /*------------------------------------- Player9 Name------------------------------------------------------------------------------------*/
        private void nametxt9_TextChanged(object sender, EventArgs e)           //Set Ninth player name
        {
            name[8] = nametxt9.Text;
            nametxt9.Text = name[8];
            nametimetxt9.Text = name[8];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn9_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt9.BackColor = Color.LightSalmon;
                twoattempttxt9.BackColor = Color.LightSalmon;
                twomadetxt9.BackColor = Color.LightSalmon;
                threeattempttxt9.BackColor = Color.LightSalmon;
                threemadetxt9.BackColor = Color.LightSalmon;
                flattmpttxt9.BackColor = Color.LightSalmon;
                flamdettxt9.BackColor = Color.LightSalmon;
                assisttxt9.BackColor = Color.LightSalmon;
                turnovertxt9.BackColor = Color.LightSalmon;
                offrebtxt9.BackColor = Color.LightSalmon;
                defrebtxt9.BackColor = Color.LightSalmon;
                deflfsttxt9.BackColor = Color.LightSalmon;
                deflsndtxt9.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt9.BackColor = Color.White;
                twoattempttxt9.BackColor = Color.White;
                twomadetxt9.BackColor = Color.White;
                threeattempttxt9.BackColor = Color.White;
                threemadetxt9.BackColor = Color.White;
                flattmpttxt9.BackColor = Color.White;
                flamdettxt9.BackColor = Color.White;
                assisttxt9.BackColor = Color.White;
                turnovertxt9.BackColor = Color.White;
                offrebtxt9.BackColor = Color.White;
                defrebtxt9.BackColor = Color.White;
                deflfsttxt9.BackColor = Color.White;
                deflsndtxt9.BackColor = Color.White;
                change = true;
            }

        }
        /*------------------------------------- Player9 Number----------------------------------------------------------------------------------*/
        private void textBox9_TextChanged(object sender, EventArgs e)              //set Ninth player number
        {
            number[8] = textBox9.Text;
            textBox9.Text = number[8];
            textBox121.Text = number[8];
            textBox9.Show();
        }

        /*------------------------------------- Player9 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn9_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt9.Text = "0";
            twonumattempt1[8] = twonumattempt1[8] + 1;
            twovalueattempt[8] = Double.Parse(twoattempttxt9.Text) + twonumattempt1[8] + twovaluemade[8];
            twoattempttxt9.Text = (twovalueattempt[8].ToString());
            twoattmpt[8] = twoattempttxt9.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt9_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn9_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt9.Text = "0";
            twonumattempt1[8] = twonumattempt1[8] - 1;
            twovalueattempt[8] = Double.Parse(twoattempttxt9.Text) + twonumattempt1[8] + twovaluemade[8];
            twoattempttxt9.Text = (twovalueattempt[8].ToString());
            twoattmpt[8] = twoattempttxt9.Text;
        }

        private void twomadeaddbtn9_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt9.Text = "0";
            twomadetxt9.Text = "0";
            twonummade[8] = twonummade[8] + 1;

            twovaluemade[8] = Double.Parse(twomadetxt9.Text) + twonummade[8];
            twovalueattempt[8] = Double.Parse(twoattempttxt9.Text) + twonumattempt1[8] + twovaluemade[8];
            twoattempttxt9.Text = (twovalueattempt[8].ToString());
            twomadetxt9.Text = (twovaluemade[8].ToString());
            twomde[8] = twomadetxt9.Text;
        }

        private void twomadesubbtn9_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt9.Text = "0";
            twomadetxt9.Text = "0";
            twonummade[8] = twonummade[8] - 1;

            twovaluemade[8] = Double.Parse(twomadetxt9.Text) + twonummade[8];
            twovalueattempt[8] = Double.Parse(twoattempttxt9.Text) + twonumattempt1[8] + twovaluemade[8];
            twoattempttxt9.Text = (twovalueattempt[8].ToString());
            twomadetxt9.Text = (twovaluemade[8].ToString());
            twomde[8] = twomadetxt9.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn9_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt9.Text = "0";
            threenumattempt1[8] = threenumattempt1[8] + 1;
            threevalueattempt[8] = Double.Parse(threeattempttxt9.Text) + threenumattempt1[8] + threevaluemade[8];
            threeattempttxt9.Text = (threevalueattempt[8].ToString());
            threeattmpt[8] = threeattempttxt9.Text;

        }

        private void threeattsubbtn9_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt9.Text = "0";
            threenumattempt1[8] = threenumattempt1[8] - 1;
            threevalueattempt[8] = Double.Parse(threeattempttxt9.Text) + threenumattempt1[8] + threevaluemade[8];
            threeattempttxt9.Text = (threevalueattempt[8].ToString());
            threeattmpt[8] = threeattempttxt9.Text;
        }

        private void threemadeaddbtn9_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt9.Text = "0";
            threemadetxt9.Text = "0";
            threenummade[8] = threenummade[8] + 1;

            threevaluemade[8] = Double.Parse(threemadetxt9.Text) + threenummade[8];
            threevalueattempt[8] = Double.Parse(threeattempttxt9.Text) + threenumattempt1[8] + threevaluemade[8];
            threeattempttxt9.Text = (threevalueattempt[8].ToString());
            threemadetxt9.Text = (threevaluemade[8].ToString());
            threemde[8] = threemadetxt9.Text;
        }

        private void threemadesubbtn9_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt9.Text = "0";
            threemadetxt9.Text = "0";
            threenummade[8] = threenummade[8] - 1;

            threevaluemade[8] = Double.Parse(threemadetxt9.Text) + threenummade[8];
            threevalueattempt[8] = Double.Parse(threeattempttxt9.Text) + threenumattempt1[8] + threevaluemade[8];
            threeattempttxt9.Text = (threevalueattempt[8].ToString());
            threemadetxt9.Text = (threevaluemade[8].ToString());
            threemde[8] = threemadetxt9.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn9_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt9.Text = "0";
            foulnumattempt[8] = foulnumattempt[8] + 1;
            foulshotattempt[8] = Double.Parse(flattmpttxt9.Text) + foulnumattempt[8] + foulshotmade[8];

            flattmpttxt9.Text = (foulshotattempt[8].ToString());
            flattmpt[8] = flattmpttxt9.Text;

        }

        private void flattmptsubbtn9_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt9.Text = "0";
            foulnumattempt[8] = foulnumattempt[8] - 1;
            foulshotattempt[8] = Double.Parse(flattmpttxt9.Text) + foulnumattempt[8] + foulshotmade[8];

            flattmpttxt9.Text = (foulshotattempt[8].ToString());
            flattmpt[8] = flattmpttxt9.Text;
        }

        private void flmadeaddbtn9_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt9.Text = "0";
            flamdettxt9.Text = "0";
            foulnummade[8] = foulnummade[8] + 1;

            foulshotmade[8] = Double.Parse(flamdettxt9.Text) + foulnummade[8];
            foulshotattempt[8] = Double.Parse(flattmpttxt9.Text) + foulnumattempt[8] + foulshotmade[8];
            flattmpttxt9.Text = (foulshotattempt[8].ToString());
            flamdettxt9.Text = (foulshotmade[8].ToString());
            flamde[8] = flamdettxt9.Text;
        }

        private void flmadesubbtn9_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt9.Text = "0";
            flamdettxt9.Text = "0";
            foulnummade[8] = foulnummade[8] - 1;

            foulshotmade[8] = Double.Parse(flamdettxt9.Text) + foulnummade[8];
            foulshotattempt[8] = Double.Parse(flattmpttxt9.Text) + foulnumattempt[8] + foulshotmade[8];
            flattmpttxt9.Text = (foulshotattempt[8].ToString());
            flamdettxt9.Text = (foulshotmade[8].ToString());
            flamde[8] = flamdettxt9.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn9_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt9.Text = "0";
            assistnum[8] = assistnum[8] + 1;

            assistvalue[8] = Double.Parse(assisttxt9.Text) + assistnum[8];
            assisttxt9.Text = (assistvalue[8].ToString());
            assist[8] = assisttxt9.Text;
        }

        private void assistsubbtn9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt9.Text = "0";
            assistnum[8] = assistnum[8] - 1;

            assistvalue[8] = Double.Parse(assisttxt9.Text) + assistnum[8];
            assisttxt9.Text = (assistvalue[8].ToString());
            assist[8] = assisttxt9.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn9_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt9.Text = "0";
            turnovernum[8] = turnovernum[8] + 1;
            turnovervalue[8] = Double.Parse(turnovertxt9.Text) + turnovernum[8];
            turnovertxt9.Text = (turnovervalue[8].ToString());
            turnover[8] = turnovertxt9.Text;
        }

        private void trnvrssubbtn9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt9.Text = "0";
            turnovernum[8] = turnovernum[8] - 1;
            turnovervalue[8] = Double.Parse(turnovertxt9.Text) + turnovernum[8];
            turnovertxt9.Text = (turnovervalue[8].ToString());
            turnover[8] = turnovertxt9.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn9_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt9.Text = "0";
            offrebnum[8] = offrebnum[8] + 1;

            offrebvalue[8] = Double.Parse(offrebtxt9.Text) + offrebnum[8];
            offrebtxt9.Text = (offrebvalue[8].ToString());
            reboff[8] = offrebtxt9.Text;
        }

        private void offsubrebbtn9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt9.Text = "0";
            offrebnum[8] = offrebnum[8] - 1;

            offrebvalue[8] = Double.Parse(offrebtxt9.Text) + offrebnum[8];
            offrebtxt9.Text = (offrebvalue[8].ToString());
            reboff[8] = offrebtxt9.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn9_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt9.Text = "0";
            defrebnum[8] = defrebnum[8] + 1;

            defrebvalue[8] = Double.Parse(defrebtxt9.Text) + defrebnum[8];
            defrebtxt9.Text = (defrebvalue[8].ToString());
            rebdef[8] = defrebtxt9.Text;
        }

        private void defsubrebbtn9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt9.Text = "0";
            defrebnum[8] = defrebnum[8] - 1;

            defrebvalue[8] = Double.Parse(defrebtxt9.Text) + defrebnum[8];
            defrebtxt9.Text = (defrebvalue[8].ToString());
            rebdef[8] = defrebtxt9.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn9_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt9.Text = "0";
            deflectfstnum[8] = deflectfstnum[8] + 1;

            deflectfstvalue[8] = Double.Parse(deflfsttxt9.Text) + deflectfstnum[8];
            deflfsttxt9.Text = (deflectfstvalue[8].ToString());
            deflectfirst[8] = deflfsttxt9.Text;
        }

        private void deflectsubfstbtn9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt9.Text = "0";
            deflectfstnum[8] = deflectfstnum[8] - 1;

            deflectfstvalue[8] = Double.Parse(deflfsttxt9.Text) + deflectfstnum[8];
            deflfsttxt9.Text = (deflectfstvalue[8].ToString());
            deflectfirst[8] = deflfsttxt9.Text;
        }

        private void deflectaddsndbtn9_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt9.Text = "0";
            deflectsndnum[8] = deflectsndnum[8] + 1;

            deflectsndvalue[8] = Double.Parse(deflsndtxt9.Text) + deflectsndnum[8];
            deflsndtxt9.Text = (deflectsndvalue[8].ToString());
            deflectsecond[8] = deflsndtxt9.Text;
        }

        private void deflectsubsndbtn9_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt9.Text = "0";
            deflectsndnum[8] = deflectsndnum[8] - 1;

            deflectsndvalue[8] = Double.Parse(deflsndtxt9.Text) + deflectsndnum[8];
            deflsndtxt9.Text = (deflectsndvalue[8].ToString());
            deflectsecond[8] = deflsndtxt9.Text;
        }
        /*-------------------------------------------------------------------- END OF PLAYER9 ------------------------------------------------------------------*/

        /*------------------------------------- Player10 Name------------------------------------------------------------------------------------*/
        private void nametxt10_TextChanged(object sender, EventArgs e)           //Set Tenth player name
        {
            name[9] = nametxt10.Text;
            nametxt10.Text = name[9];
            nametimetxt10.Text = name[9];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn10_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt10.BackColor = Color.LightSalmon;
                twoattempttxt10.BackColor = Color.LightSalmon;
                twomadetxt10.BackColor = Color.LightSalmon;
                threeattempttxt10.BackColor = Color.LightSalmon;
                threemadetxt10.BackColor = Color.LightSalmon;
                flattmpttxt10.BackColor = Color.LightSalmon;
                flamdettxt10.BackColor = Color.LightSalmon;
                assisttxt10.BackColor = Color.LightSalmon;
                turnovertxt10.BackColor = Color.LightSalmon;
                offrebtxt10.BackColor = Color.LightSalmon;
                defrebtxt10.BackColor = Color.LightSalmon;
                deflfsttxt10.BackColor = Color.LightSalmon;
                deflsndtxt10.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt10.BackColor = Color.White;
                twoattempttxt10.BackColor = Color.White;
                twomadetxt10.BackColor = Color.White;
                threeattempttxt10.BackColor = Color.White;
                threemadetxt10.BackColor = Color.White;
                flattmpttxt10.BackColor = Color.White;
                flamdettxt10.BackColor = Color.White;
                assisttxt10.BackColor = Color.White;
                turnovertxt10.BackColor = Color.White;
                offrebtxt10.BackColor = Color.White;
                defrebtxt10.BackColor = Color.White;
                deflfsttxt10.BackColor = Color.White;
                deflsndtxt10.BackColor = Color.White;
                change = true;
            }

        }
        /*------------------------------------- Player10 Number----------------------------------------------------------------------------------*/
        private void textBox10_TextChanged(object sender, EventArgs e)              //set Tenth player number
        {
            number[9] = textBox10.Text;
            textBox10.Text = number[9];
            textBox37.Text = number[9];
            textBox10.Show();
        }

        /*------------------------------------- Player10 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn10_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt10.Text = "0";
            twonumattempt1[9] = twonumattempt1[9] + 1;
            twovalueattempt[9] = Double.Parse(twoattempttxt10.Text) + twonumattempt1[9] + twovaluemade[9];
            twoattempttxt10.Text = (twovalueattempt[9].ToString());
            twoattmpt[9] = twoattempttxt10.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt10_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn10_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt10.Text = "0";
            twonumattempt1[9] = twonumattempt1[9] - 1;
            twovalueattempt[9] = Double.Parse(twoattempttxt10.Text) + twonumattempt1[9] + twovaluemade[9];
            twoattempttxt10.Text = (twovalueattempt[9].ToString());
            twoattmpt[9] = twoattempttxt10.Text;
        }

        private void twomadeaddbtn10_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt10.Text = "0";
            twomadetxt10.Text = "0";
            twonummade[9] = twonummade[9] + 1;

            twovaluemade[9] = Double.Parse(twomadetxt10.Text) + twonummade[9];
            twovalueattempt[9] = Double.Parse(twoattempttxt10.Text) + twonumattempt1[9] + twovaluemade[9];
            twoattempttxt10.Text = (twovalueattempt[9].ToString());
            twomadetxt10.Text = (twovaluemade[9].ToString());
            twomde[9] = twomadetxt10.Text;
        }

        private void twomadesubbtn10_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt10.Text = "0";
            twomadetxt10.Text = "0";
            twonummade[9] = twonummade[9] - 1;

            twovaluemade[9] = Double.Parse(twomadetxt10.Text) + twonummade[9];
            twovalueattempt[9] = Double.Parse(twoattempttxt10.Text) + twonumattempt1[9] + twovaluemade[9];
            twoattempttxt10.Text = (twovalueattempt[9].ToString());
            twomadetxt10.Text = (twovaluemade[9].ToString());
            twomde[9] = twomadetxt10.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn10_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt10.Text = "0";
            threenumattempt1[9] = threenumattempt1[9] + 1;
            threevalueattempt[9] = Double.Parse(threeattempttxt10.Text) + threenumattempt1[9] + threevaluemade[9];
            threeattempttxt10.Text = (threevalueattempt[9].ToString());
            threeattmpt[9] = threeattempttxt10.Text;

        }

        private void threeattsubbtn10_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt10.Text = "0";
            threenumattempt1[9] = threenumattempt1[9] - 1;
            threevalueattempt[9] = Double.Parse(threeattempttxt10.Text) + threenumattempt1[9] + threevaluemade[9];
            threeattempttxt10.Text = (threevalueattempt[9].ToString());
            threeattmpt[9] = threeattempttxt10.Text;
        }

        private void threemadeaddbtn10_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt10.Text = "0";
            threemadetxt10.Text = "0";
            threenummade[9] = threenummade[9] + 1;

            threevaluemade[9] = Double.Parse(threemadetxt10.Text) + threenummade[9];
            threevalueattempt[9] = Double.Parse(threeattempttxt10.Text) + threenumattempt1[9] + threevaluemade[9];
            threeattempttxt10.Text = (threevalueattempt[9].ToString());
            threemadetxt10.Text = (threevaluemade[9].ToString());
            threemde[9] = threemadetxt10.Text;
        }

        private void threemadesubbtn10_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt10.Text = "0";
            threemadetxt10.Text = "0";
            threenummade[9] = threenummade[9] - 1;

            threevaluemade[9] = Double.Parse(threemadetxt10.Text) + threenummade[9];
            threevalueattempt[9] = Double.Parse(threeattempttxt10.Text) + threenumattempt1[9] + threevaluemade[9];
            threeattempttxt10.Text = (threevalueattempt[9].ToString());
            threemadetxt10.Text = (threevaluemade[9].ToString());
            threemde[9] = threemadetxt10.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn10_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt10.Text = "0";
            foulnumattempt[9] = foulnumattempt[9] + 1;
            foulshotattempt[9] = Double.Parse(flattmpttxt10.Text) + foulnumattempt[9] + foulshotmade[9];

            flattmpttxt10.Text = (foulshotattempt[9].ToString());
            flattmpt[9] = flattmpttxt10.Text;


        }

        private void flattmptsubbtn10_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt10.Text = "0";
            foulnumattempt[9] = foulnumattempt[9] - 1;
            foulshotattempt[9] = Double.Parse(flattmpttxt10.Text) + foulnumattempt[9] + foulshotmade[9];

            flattmpttxt10.Text = (foulshotattempt[9].ToString());
            flattmpt[9] = flattmpttxt10.Text;
        }

        private void flmadeaddbtn10_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt10.Text = "0";
            flamdettxt10.Text = "0";
            foulnummade[9] = foulnummade[9] + 1;

            foulshotmade[9] = Double.Parse(flamdettxt10.Text) + foulnummade[9];
            foulshotattempt[9] = Double.Parse(flattmpttxt10.Text) + foulnumattempt[9] + foulshotmade[9];
            flattmpttxt10.Text = (foulshotattempt[9].ToString());
            flamdettxt10.Text = (foulshotmade[9].ToString());
            flamde[9] = flamdettxt10.Text;
            flattmpt[9] = flattmpttxt10.Text;
        }

        private void flmadesubbtn10_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt10.Text = "0";
            flamdettxt10.Text = "0";
            foulnummade[9] = foulnummade[9] - 1;

            foulshotmade[9] = Double.Parse(flamdettxt10.Text) + foulnummade[9];
            foulshotattempt[9] = Double.Parse(flattmpttxt10.Text) + foulnumattempt[9] + foulshotmade[9];
            flattmpttxt10.Text = (foulshotattempt[9].ToString());
            flamdettxt10.Text = (foulshotmade[9].ToString());
            flamde[9] = flamdettxt10.Text;
            flattmpt[9] = flattmpttxt10.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn10_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt10.Text = "0";
            assistnum[9] = assistnum[9] + 1;

            assistvalue[9] = Double.Parse(assisttxt10.Text) + assistnum[9];
            assisttxt10.Text = (assistvalue[9].ToString());
            assist[9] = assisttxt10.Text;
        }

        private void assistsubbtn10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt10.Text = "0";
            assistnum[9] = assistnum[9] - 1;

            assistvalue[9] = Double.Parse(assisttxt10.Text) + assistnum[9];
            assisttxt10.Text = (assistvalue[9].ToString());
            assist[9] = assisttxt10.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn10_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt10.Text = "0";
            turnovernum[9] = turnovernum[9] + 1;
            turnovervalue[9] = Double.Parse(turnovertxt10.Text) + turnovernum[9];
            turnovertxt10.Text = (turnovervalue[9].ToString());
            turnover[9] = turnovertxt10.Text;
        }

        private void trnvrssubbtn10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt10.Text = "0";
            turnovernum[9] = turnovernum[9] - 1;
            turnovervalue[9] = Double.Parse(turnovertxt10.Text) + turnovernum[9];
            turnovertxt10.Text = (turnovervalue[9].ToString());
            turnover[9] = turnovertxt10.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn10_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt10.Text = "0";
            offrebnum[9] = offrebnum[9] + 1;

            offrebvalue[9] = Double.Parse(offrebtxt10.Text) + offrebnum[9];
            offrebtxt10.Text = (offrebvalue[9].ToString());
            reboff[9] = offrebtxt10.Text;
        }

        private void offsubrebbtn10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt10.Text = "0";
            offrebnum[9] = offrebnum[9] - 1;

            offrebvalue[9] = Double.Parse(offrebtxt10.Text) + offrebnum[9];
            offrebtxt10.Text = (offrebvalue[9].ToString());
            reboff[9] = offrebtxt10.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn10_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt10.Text = "0";
            defrebnum[9] = defrebnum[9] + 1;

            defrebvalue[9] = Double.Parse(defrebtxt10.Text) + defrebnum[9];
            defrebtxt10.Text = (defrebvalue[9].ToString());
            rebdef[9] = defrebtxt10.Text;
        }

        private void defsubrebbtn10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt10.Text = "0";
            defrebnum[9] = defrebnum[9] - 1;

            defrebvalue[9] = Double.Parse(defrebtxt10.Text) + defrebnum[9];
            defrebtxt10.Text = (defrebvalue[9].ToString());
            rebdef[9] = defrebtxt10.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn10_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt10.Text = "0";
            deflectfstnum[9] = deflectfstnum[9] + 1;

            deflectfstvalue[9] = Double.Parse(deflfsttxt10.Text) + deflectfstnum[9];
            deflfsttxt10.Text = (deflectfstvalue[9].ToString());
            deflectfirst[9] = deflfsttxt10.Text;
        }

        private void deflectsubfstbtn10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt10.Text = "0";
            deflectfstnum[9] = deflectfstnum[9] - 1;

            deflectfstvalue[9] = Double.Parse(deflfsttxt10.Text) + deflectfstnum[9];
            deflfsttxt10.Text = (deflectfstvalue[9].ToString());
            deflectfirst[9] = deflfsttxt10.Text;
        }

        private void deflectaddsndbtn10_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt10.Text = "0";
            deflectsndnum[9] = deflectsndnum[9] + 1;

            deflectsndvalue[9] = Double.Parse(deflsndtxt10.Text) + deflectsndnum[9];
            deflsndtxt10.Text = (deflectsndvalue[9].ToString());
            deflectsecond[9] = deflsndtxt10.Text;
        }

        private void deflectsubsndbtn10_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt10.Text = "0";
            deflectsndnum[9] = deflectsndnum[9] - 1;

            deflectsndvalue[9] = Double.Parse(deflsndtxt10.Text) + deflectsndnum[9];
            deflsndtxt10.Text = (deflectsndvalue[9].ToString());
            deflectsecond[9] = deflsndtxt10.Text;
        }

 
        /*-------------------------------------------------------------------- END OF PLAYER10 ------------------------------------------------------------------*/

        /*------------------------------------- Player11 Name------------------------------------------------------------------------------------*/
        private void nametxt11_TextChanged(object sender, EventArgs e)           //Set Eleventh player name
        {
            name[10] = nametxt11.Text;
            nametxt11.Text = name[10];
            nametimetxt11.Text = name[10];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn11_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt11.BackColor = Color.LightSalmon;
                twoattempttxt11.BackColor = Color.LightSalmon;
                twomadetxt11.BackColor = Color.LightSalmon;
                threeattempttxt11.BackColor = Color.LightSalmon;
                threemadetxt11.BackColor = Color.LightSalmon;
                flattmpttxt11.BackColor = Color.LightSalmon;
                flamdettxt11.BackColor = Color.LightSalmon;
                assisttxt11.BackColor = Color.LightSalmon;
                turnovertxt11.BackColor = Color.LightSalmon;
                offrebtxt11.BackColor = Color.LightSalmon;
                defrebtxt11.BackColor = Color.LightSalmon;
                deflfsttxt11.BackColor = Color.LightSalmon;
                deflsndtxt11.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt11.BackColor = Color.White;
                twoattempttxt11.BackColor = Color.White;
                twomadetxt11.BackColor = Color.White;
                threeattempttxt11.BackColor = Color.White;
                threemadetxt11.BackColor = Color.White;
                flattmpttxt11.BackColor = Color.White;
                flamdettxt11.BackColor = Color.White;
                assisttxt11.BackColor = Color.White;
                turnovertxt11.BackColor = Color.White;
                offrebtxt11.BackColor = Color.White;
                defrebtxt11.BackColor = Color.White;
                deflfsttxt11.BackColor = Color.White;
                deflsndtxt11.BackColor = Color.White;
                change = true;
            }

        }
        /*------------------------------------- Player11 Number----------------------------------------------------------------------------------*/
        private void textBox11_TextChanged(object sender, EventArgs e)              //set Eleventh player number
        {
            number[10] = textBox11.Text;
            textBox11.Text = number[10];
            textBox39.Text = number[10];
            textBox11.Show();
        }

        /*------------------------------------- Player11 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn11_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt11.Text = "0";
            twonumattempt1[10] = twonumattempt1[10] + 1;
            twovalueattempt[10] = Double.Parse(twoattempttxt11.Text) + twonumattempt1[10] + twovaluemade[10];
            twoattempttxt11.Text = (twovalueattempt[10].ToString());
            twoattmpt[10] = twoattempttxt11.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt11_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn11_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt11.Text = "0";
            twonumattempt1[10] = twonumattempt1[10] - 1;
            twovalueattempt[10] = Double.Parse(twoattempttxt11.Text) + twonumattempt1[10] + twovaluemade[10];
            twoattempttxt11.Text = (twovalueattempt[10].ToString());
            twoattmpt[10] = twoattempttxt11.Text;
        }

        private void twomadeaddbtn11_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt11.Text = "0";
            twomadetxt11.Text = "0";
            twonummade[10] = twonummade[10] + 1;

            twovaluemade[10] = Double.Parse(twomadetxt11.Text) + twonummade[10];
            twovalueattempt[10] = Double.Parse(twoattempttxt11.Text) + twonumattempt1[10] + twovaluemade[10];
            twoattempttxt11.Text = (twovalueattempt[10].ToString());
            twomadetxt11.Text = (twovaluemade[10].ToString());
            twomde[10] = twomadetxt11.Text;
        }

        private void twomadesubbtn11_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt11.Text = "0";
            twomadetxt11.Text = "0";
            twonummade[10] = twonummade[10] - 1;

            twovaluemade[10] = Double.Parse(twomadetxt11.Text) + twonummade[10];
            twovalueattempt[10] = Double.Parse(twoattempttxt11.Text) + twonumattempt1[10] + twovaluemade[10];
            twoattempttxt11.Text = (twovalueattempt[10].ToString());
            twomadetxt11.Text = (twovaluemade[10].ToString());
            twomde[10] = twomadetxt11.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn11_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt11.Text = "0";
            threenumattempt1[10] = threenumattempt1[10] + 1;
            threevalueattempt[10] = Double.Parse(threeattempttxt11.Text) + threenumattempt1[10] + threevaluemade[10];
            threeattempttxt11.Text = (threevalueattempt[10].ToString());
            threeattmpt[10] = threeattempttxt11.Text;

        }

        private void threeattsubbtn11_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt11.Text = "0";
            threenumattempt1[10] = threenumattempt1[10] - 1;
            threevalueattempt[10] = Double.Parse(threeattempttxt11.Text) + threenumattempt1[10] + threevaluemade[10];
            threeattempttxt11.Text = (threevalueattempt[10].ToString());
            threeattmpt[10] = threeattempttxt11.Text;
        }

        private void threemadeaddbtn11_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt11.Text = "0";
            threemadetxt11.Text = "0";
            threenummade[10] = threenummade[10] + 1;

            threevaluemade[10] = Double.Parse(threemadetxt11.Text) + threenummade[10];
            threevalueattempt[10] = Double.Parse(threeattempttxt11.Text) + threenumattempt1[10] + threevaluemade[10];
            threeattempttxt11.Text = (threevalueattempt[10].ToString());
            threemadetxt11.Text = (threevaluemade[10].ToString());
            threemde[10] = threemadetxt11.Text;
        }

        private void threemadesubbtn11_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt11.Text = "0";
            threemadetxt11.Text = "0";
            threenummade[10] = threenummade[10] - 1;

            threevaluemade[10] = Double.Parse(threemadetxt11.Text) + threenummade[10];
            threevalueattempt[10] = Double.Parse(threeattempttxt11.Text) + threenumattempt1[10] + threevaluemade[10];
            threeattempttxt11.Text = (threevalueattempt[10].ToString());
            threemadetxt11.Text = (threevaluemade[10].ToString());
            threemde[10] = threemadetxt11.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn11_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt11.Text = "0";
            foulnumattempt[10] = foulnumattempt[10] + 1;
            foulshotattempt[10] = Double.Parse(flattmpttxt11.Text) + foulnumattempt[10] + foulshotmade[10];

            flattmpttxt11.Text = (foulshotattempt[10].ToString());
            flattmpt[10] = flattmpttxt11.Text;


        }

        private void flattmptsubbtn11_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt11.Text = "0";
            foulnumattempt[10] = foulnumattempt[10] - 1;
            foulshotattempt[10] = Double.Parse(flattmpttxt11.Text) + foulnumattempt[10] + foulshotmade[10];

            flattmpttxt11.Text = (foulshotattempt[10].ToString());
            flattmpt[10] = flattmpttxt11.Text;
        }

        private void flmadeaddbtn11_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt11.Text = "0";
            flamdettxt11.Text = "0";
            foulnummade[10] = foulnummade[10] + 1;

            foulshotmade[10] = Double.Parse(flamdettxt11.Text) + foulnummade[10];
            foulshotattempt[10] = Double.Parse(flattmpttxt11.Text) + foulnumattempt[10] + foulshotmade[10];
            flattmpttxt11.Text = (foulshotattempt[10].ToString());
            flamdettxt11.Text = (foulshotmade[10].ToString());
            flamde[10] = flamdettxt11.Text;
        }

        private void flmadesubbtn11_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt11.Text = "0";
            flamdettxt11.Text = "0";
            foulnummade[10] = foulnummade[10] - 1;

            foulshotmade[10] = Double.Parse(flamdettxt11.Text) + foulnummade[10];
            foulshotattempt[10] = Double.Parse(flattmpttxt11.Text) + foulnumattempt[10] + foulshotmade[10];
            flattmpttxt11.Text = (foulshotattempt[10].ToString());
            flamdettxt11.Text = (foulshotmade[10].ToString());
            flamde[10] = flamdettxt11.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn11_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt11.Text = "0";
            assistnum[10] = assistnum[10] + 1;

            assistvalue[10] = Double.Parse(assisttxt11.Text) + assistnum[10];
            assisttxt11.Text = (assistvalue[10].ToString());
            assist[10] = assisttxt11.Text;
        }

        private void assistsubbtn11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt11.Text = "0";
            assistnum[10] = assistnum[10] - 1;

            assistvalue[10] = Double.Parse(assisttxt11.Text) + assistnum[10];
            assisttxt11.Text = (assistvalue[10].ToString());
            assist[10] = assisttxt11.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn11_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt11.Text = "0";
            turnovernum[10] = turnovernum[10] + 1;
            turnovervalue[10] = Double.Parse(turnovertxt11.Text) + turnovernum[10];
            turnovertxt11.Text = (turnovervalue[10].ToString());
            turnover[10] = turnovertxt11.Text;
        }

        private void trnvrssubbtn11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt11.Text = "0";
            turnovernum[10] = turnovernum[10] - 1;
            turnovervalue[10] = Double.Parse(turnovertxt11.Text) + turnovernum[10];
            turnovertxt11.Text = (turnovervalue[10].ToString());
            turnover[10] = turnovertxt11.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn11_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt11.Text = "0";
            offrebnum[10] = offrebnum[10] + 1;

            offrebvalue[10] = Double.Parse(offrebtxt11.Text) + offrebnum[10];
            offrebtxt11.Text = (offrebvalue[10].ToString());
            reboff[10] = offrebtxt11.Text;
        }

        private void offsubrebbtn11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt11.Text = "0";
            offrebnum[10] = offrebnum[10] - 1;

            offrebvalue[10] = Double.Parse(offrebtxt1.Text) + offrebnum[10];
            offrebtxt11.Text = (offrebvalue[10].ToString());
            reboff[10] = offrebtxt11.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn11_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt11.Text = "0";
            defrebnum[10] = defrebnum[10] + 1;

            defrebvalue[10] = Double.Parse(defrebtxt11.Text) + defrebnum[10];
            defrebtxt11.Text = (defrebvalue[10].ToString());
            rebdef[10] = defrebtxt11.Text;
        }

        private void defsubrebbtn11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt11.Text = "0";
            defrebnum[10] = defrebnum[10] - 1;

            defrebvalue[10] = Double.Parse(defrebtxt11.Text) + defrebnum[10];
            defrebtxt11.Text = (defrebvalue[10].ToString());
            rebdef[10] = defrebtxt11.Text;
        }
        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn11_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt11.Text = "0";
            deflectfstnum[10] = deflectfstnum[10] + 1;

            deflectfstvalue[10] = Double.Parse(deflfsttxt11.Text) + deflectfstnum[10];
            deflfsttxt11.Text = (deflectfstvalue[10].ToString());
            deflectfirst[10] = deflfsttxt11.Text;
        }

        private void deflectsubfstbtn11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt11.Text = "0";
            deflectfstnum[10] = deflectfstnum[10] - 1;

            deflectfstvalue[10] = Double.Parse(deflfsttxt11.Text) + deflectfstnum[10];
            deflfsttxt11.Text = (deflectfstvalue[10].ToString());
            deflectfirst[10] = deflfsttxt11.Text;
        }

        private void deflectaddsndbtn11_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt11.Text = "0";
            deflectsndnum[10] = deflectsndnum[10] + 1;

            deflectsndvalue[10] = Double.Parse(deflsndtxt11.Text) + deflectsndnum[10];
            deflsndtxt11.Text = (deflectsndvalue[10].ToString());
            deflectsecond[10] = deflsndtxt11.Text;
        }

        private void deflectsubsndbtn11_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt11.Text = "0";
            deflectsndnum[10] = deflectsndnum[10] - 1;

            deflectsndvalue[10] = Double.Parse(deflsndtxt11.Text) + deflectsndnum[10];
            deflsndtxt11.Text = (deflectsndvalue[10].ToString());
            deflectsecond[10] = deflsndtxt11.Text;
        }
        /*-------------------------------------------------------------------- END OF PLAYER11 ------------------------------------------------------------------*/

        /*------------------------------------- Player12 Name------------------------------------------------------------------------------------*/
        private void nametxt12_TextChanged(object sender, EventArgs e)           //Set Twelfth player name
        {
            name[11] = nametxt12.Text;
            nametxt12.Text = name[11];
            nametimetxt12.Text = name[11];
            //textBox1.Show();
        }

        /*--------CHANGE COLOR OF PLAYERNAME TEXTBOX-------------------------------*/
        private void activebtn12_Click(object sender, EventArgs e)
        {


            if (change)
            {
                nametxt12.BackColor = Color.LightSalmon;
                twoattempttxt12.BackColor = Color.LightSalmon;
                twomadetxt12.BackColor = Color.LightSalmon;
                threeattempttxt12.BackColor = Color.LightSalmon;
                threemadetxt12.BackColor = Color.LightSalmon;
                flattmpttxt12.BackColor = Color.LightSalmon;
                flamdettxt12.BackColor = Color.LightSalmon;
                assisttxt12.BackColor = Color.LightSalmon;
                turnovertxt12.BackColor = Color.LightSalmon;
                offrebtxt12.BackColor = Color.LightSalmon;
                defrebtxt12.BackColor = Color.LightSalmon;
                deflfsttxt12.BackColor = Color.LightSalmon;
                deflsndtxt12.BackColor = Color.LightSalmon;

                change = false;
            }
            else {
                nametxt12.BackColor = Color.White;
                twoattempttxt12.BackColor = Color.White;
                twomadetxt12.BackColor = Color.White;
                threeattempttxt12.BackColor = Color.White;
                threemadetxt12.BackColor = Color.White;
                flattmpttxt12.BackColor = Color.White;
                flamdettxt12.BackColor = Color.White;
                assisttxt12.BackColor = Color.White;
                turnovertxt12.BackColor = Color.White;
                offrebtxt12.BackColor = Color.White;
                defrebtxt12.BackColor = Color.White;
                deflfsttxt12.BackColor = Color.White;
                deflsndtxt12.BackColor = Color.White;
                change = true;
            }

        }
        /*------------------------------------- Player12 Number----------------------------------------------------------------------------------*/
        private void textBox12_TextChanged(object sender, EventArgs e)              //set Twelfth player number
        {
            number[11] = textBox12.Text;
            textBox12.Text = number[11];
            textBox41.Text = number[11];
            textBox12.Show();
        }

        /*------------------------------------- Player12 Statistics------------------------------------------------------------------------------*/
        private void twoattemptaddbtn12_Click(object sender, EventArgs e)        //add 2 point attempts to 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt12.Text = "0";
            twonumattempt1[11] = twonumattempt1[11] + 1;
            twovalueattempt[11] = Double.Parse(twoattempttxt12.Text) + twonumattempt1[11] + twovaluemade[11];
            twoattempttxt12.Text = (twovalueattempt[11].ToString());
            twoattmpt[11] = twoattempttxt12.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void twoattempttxt12_TextChanged(object sender, EventArgs e)
        {
        }

        /*-----------------------2 PT ATTMPTS -----------------------------*/

        private void twoattemptsubbtn12_Click(object sender, EventArgs e)            //subtract 2 point attempts from 2 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt12.Text = "0";
            twonumattempt1[11] = twonumattempt1[11] - 1;
            twovalueattempt[11] = Double.Parse(twoattempttxt12.Text) + twonumattempt1[11] + twovaluemade[11];
            twoattempttxt12.Text = (twovalueattempt[11].ToString());
            twoattmpt[11] = twoattempttxt12.Text;
        }

        private void twomadeaddbtn12_Click(object sender, EventArgs e)               //add 2 point baskets made to 2 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            twoattempttxt12.Text = "0";
            twomadetxt12.Text = "0";
            twonummade[11] = twonummade[11] + 1;

            twovaluemade[11] = Double.Parse(twomadetxt12.Text) + twonummade[11];
            twovalueattempt[11] = Double.Parse(twoattempttxt12.Text) + twonumattempt1[11] + twovaluemade[11];
            twoattempttxt12.Text = (twovalueattempt[11].ToString());
            twomadetxt12.Text = (twovaluemade[11].ToString());
            twomde[11] = twomadetxt12.Text;
        }

        private void twomadesubbtn12_Click(object sender, EventArgs e)               //subtract 2 point made from 2 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            twoattempttxt12.Text = "0";
            twomadetxt12.Text = "0";
            twonummade[11] = twonummade[11] - 1;

            twovaluemade[11] = Double.Parse(twomadetxt12.Text) + twonummade[11];
            twovalueattempt[11] = Double.Parse(twoattempttxt12.Text) + twonumattempt1[11] + twovaluemade[11];
            twoattempttxt12.Text = (twovalueattempt[11].ToString());
            twomadetxt12.Text = (twovaluemade[11].ToString());
            twomde[11] = twomadetxt12.Text;
        }
        /*-----------------------3 PT ATTMPTS -----------------------------*/

        private void threeattaddbtn12_Click(object sender, EventArgs e)              //add 3 point attempts to 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt12.Text = "0";
            threenumattempt1[11] = threenumattempt1[11] + 1;
            threevalueattempt[11] = Double.Parse(threeattempttxt12.Text) + threenumattempt1[11] + threevaluemade[11];
            threeattempttxt12.Text = (threevalueattempt[11].ToString());
            threeattmpt[11] = threeattempttxt12.Text;

        }

        private void threeattsubbtn12_Click(object sender, EventArgs e)               //subtract 3 point attempts from 3 point attempt box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt12.Text = "0";
            threenumattempt1[11] = threenumattempt1[11] - 1;
            threevalueattempt[11] = Double.Parse(threeattempttxt12.Text) + threenumattempt1[11] + threevaluemade[11];
            threeattempttxt12.Text = (threevalueattempt[11].ToString());
            threeattmpt[11] = threeattempttxt12.Text;
        }

        private void threemadeaddbtn12_Click(object sender, EventArgs e)              //add 3 point makes to 3 point made box
        {
            Button b = (Button)sender;
            b.Text = "+";
            threeattempttxt12.Text = "0";
            threemadetxt12.Text = "0";
            threenummade[11] = threenummade[11] + 1;

            threevaluemade[11] = Double.Parse(threemadetxt12.Text) + threenummade[11];
            threevalueattempt[11] = Double.Parse(threeattempttxt12.Text) + threenumattempt1[11] + threevaluemade[11];
            threeattempttxt12.Text = (threevalueattempt[11].ToString());
            threemadetxt12.Text = (threevaluemade[11].ToString());
            threemde[11] = threemadetxt12.Text;
        }

        private void threemadesubbtn12_Click(object sender, EventArgs e)              //subtract 3 point makes from 3 point made and attempts box
        {
            Button b = (Button)sender;
            b.Text = "-";
            threeattempttxt12.Text = "0";
            threemadetxt12.Text = "0";
            threenummade[11] = threenummade[11] - 1;

            threevaluemade[11] = Double.Parse(threemadetxt12.Text) + threenummade[11];
            threevalueattempt[11] = Double.Parse(threeattempttxt12.Text) + threenumattempt1[11] + threevaluemade[11];
            threeattempttxt12.Text = (threevalueattempt[11].ToString());
            threemadetxt12.Text = (threevaluemade[11].ToString());
            threemde[11] = threemadetxt12.Text;
        }
        /*-----------------------FOUL SHOT ATTMPTS -----------------------------*/

        private void flattmptaddbtn12_Click(object sender, EventArgs e)                //add foul shot attempts to attempts text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt12.Text = "0";
            foulnumattempt[11] = foulnumattempt[11] + 1;
            foulshotattempt[11] = Double.Parse(flattmpttxt12.Text) + foulnumattempt[11] + foulshotmade[11];

            flattmpttxt12.Text = (foulshotattempt[11].ToString());
            flattmpt[11] = flattmpttxt12.Text;


        }

        private void flattmptsubbtn12_Click(object sender, EventArgs e)                       //subtract foul shot attempts from attempts text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt12.Text = "0";
            foulnumattempt[11] = foulnumattempt[11] - 1;
            foulshotattempt[11] = Double.Parse(flattmpttxt12.Text) + foulnumattempt[11] + foulshotmade[11];

            flattmpttxt12.Text = (foulshotattempt[11].ToString());
            flattmpt[11] = flattmpttxt12.Text;
        }

        private void flmadeaddbtn12_Click(object sender, EventArgs e)                         //add foul shot makes to made text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            flattmpttxt12.Text = "0";
            flamdettxt12.Text = "0";
            foulnummade[11] = foulnummade[11] + 1;

            foulshotmade[11] = Double.Parse(flamdettxt12.Text) + foulnummade[11];
            foulshotattempt[11] = Double.Parse(flattmpttxt12.Text) + foulnumattempt[11] + foulshotmade[11];
            flattmpttxt12.Text = (foulshotattempt[11].ToString());
            flamdettxt12.Text = (foulshotmade[11].ToString());
            flamde[11] = flamdettxt12.Text;
            flattmpt[11] = flattmpttxt12.Text;
        }

        private void flmadesubbtn12_Click(object sender, EventArgs e)                         //subtract foul shot makes from made text box
        {
            Button b = (Button)sender;
            b.Text = "-";
            flattmpttxt12.Text = "0";
            flamdettxt12.Text = "0";
            foulnummade[11] = foulnummade[11] - 1;

            foulshotmade[11] = Double.Parse(flamdettxt12.Text) + foulnummade[11];
            foulshotattempt[11] = Double.Parse(flattmpttxt12.Text) + foulnumattempt[11] + foulshotmade[11];
            flattmpttxt12.Text = (foulshotattempt[11].ToString());
            flamdettxt12.Text = (foulshotmade[11].ToString());
            flamde[11] = flamdettxt12.Text;
            flattmpt[11] = flattmpttxt12.Text;
        }
        /*----------------------------ASSISTS --------------------------------*/

        private void assistaddbtn12_Click(object sender, EventArgs e)                 //add assists to assists text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            assisttxt12.Text = "0";
            assistnum[11] = assistnum[11] + 1;

            assistvalue[11] = Double.Parse(assisttxt12.Text) + assistnum[11];
            assisttxt12.Text = (assistvalue[11].ToString());
            assist[11] = assisttxt12.Text;
        }

        private void assistsubbtn12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            assisttxt12.Text = "0";
            assistnum[11] = assistnum[11] - 1;

            assistvalue[11] = Double.Parse(assisttxt12.Text) + assistnum[11];
            assisttxt12.Text = (assistvalue[11].ToString());
            assist[11] = assisttxt12.Text;
        }
        /*----------------------------TURNOVERS --------------------------------*/

        private void trnvrsaddbtn12_Click(object sender, EventArgs e)             //add turnovers to turnovers text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            turnovertxt12.Text = "0";
            turnovernum[11] = turnovernum[11] + 1;
            turnovervalue[11] = Double.Parse(turnovertxt12.Text) + turnovernum[11];
            turnovertxt12.Text = (turnovervalue[11].ToString());
            turnover[11] = turnovertxt12.Text;
        }

        private void trnvrssubbtn12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            turnovertxt12.Text = "0";
            turnovernum[11] = turnovernum[11] - 1;
            turnovervalue[11] = Double.Parse(turnovertxt12.Text) + turnovernum[11];
            turnovertxt12.Text = (turnovervalue[11].ToString());
            turnover[11] = turnovertxt12.Text;
        }
        /*------------------------OFFENSIVE REBOUNDS----------------------------*/

        private void offaddrebbtn12_Click(object sender, EventArgs e)                 //add offensive rebounds to offensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            offrebtxt12.Text = "0";
            offrebnum[11] = offrebnum[11] + 1;

            offrebvalue[11] = Double.Parse(offrebtxt12.Text) + offrebnum[11];
            offrebtxt12.Text = (offrebvalue[11].ToString());
            reboff[11] = offrebtxt12.Text;
        }

        private void offsubrebbtn12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            offrebtxt12.Text = "0";
            offrebnum[11] = offrebnum[11] - 1;

            offrebvalue[11] = Double.Parse(offrebtxt12.Text) + offrebnum[11];
            offrebtxt12.Text = (offrebvalue[11].ToString());
            reboff[11] = offrebtxt12.Text;
        }
        /*------------------------DEFENSIVE REBOUNDS----------------------------*/

        private void defaddrebbtn12_Click(object sender, EventArgs e)             //add defensive rebounds to defensive rebounds text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            defrebtxt12.Text = "0";
            defrebnum[11] = defrebnum[11] + 1;

            defrebvalue[11] = Double.Parse(defrebtxt12.Text) + defrebnum[11];
            defrebtxt12.Text = (defrebvalue[11].ToString());
            rebdef[11] = defrebtxt12.Text;
        }

        

        private void defsubrebbtn12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            defrebtxt12.Text = "0";
            defrebnum[11] = defrebnum[11] - 1;

            defrebvalue[11] = Double.Parse(defrebtxt12.Text) + defrebnum[11];
            defrebtxt12.Text = (defrebvalue[11].ToString());
            rebdef[11] = defrebtxt12.Text;
        }

        

        /*--------------------------DEFLECTIONS---------------------------------*/

        private void deflectaddfstbtn12_Click(object sender, EventArgs e)                 //add first half deflections to first half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";

            deflfsttxt12.Text = "0";
            deflectfstnum[11] = deflectfstnum[11] + 1;

            deflectfstvalue[11] = Double.Parse(deflfsttxt12.Text) + deflectfstnum[11];
            deflfsttxt12.Text = (deflectfstvalue[11].ToString());
            deflectfirst[11] = deflfsttxt12.Text;
        }

        private void deflectsubfstbtn12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflfsttxt12.Text = "0";
            deflectfstnum[11] = deflectfstnum[11] - 1;

            deflectfstvalue[11] = Double.Parse(deflfsttxt12.Text) + deflectfstnum[11];
            deflfsttxt12.Text = (deflectfstvalue[11].ToString());
            deflectfirst[11] = deflfsttxt12.Text;
        }

        private void deflectaddsndbtn12_Click(object sender, EventArgs e)            //add second half deflections to second half deflections text box
        {
            Button b = (Button)sender;
            b.Text = "+";
            deflsndtxt12.Text = "0";
            deflectsndnum[11] = deflectsndnum[11] + 1;

            deflectsndvalue[11] = Double.Parse(deflsndtxt12.Text) + deflectsndnum[11];
            deflsndtxt12.Text = (deflectsndvalue[11].ToString());
            deflectsecond[11] = deflsndtxt12.Text;
        }

        private void deflectsubsndbtn12_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text = "-";
            deflsndtxt12.Text = "0";
            deflectsndnum[11] = deflectsndnum[11] - 1;

            deflectsndvalue[11] = Double.Parse(deflsndtxt12.Text) + deflectsndnum[11];
            deflsndtxt12.Text = (deflectsndvalue[11].ToString());
            deflectsecond[11] = deflsndtxt12.Text;
        }

        /*----------------------------------------------- TEAM  TOTALS -------------------------------------------------------*/
        private void totaltwoptattmpttxt_TextChanged(object sender, EventArgs e)
        {
            totaltwoptattmpttxt.Text = totaltwoattmpt.ToString();
        }

        private void totaltwoptmadetxt_TextChanged(object sender, EventArgs e)
        {
            totaltwoptmadetxt.Text = totaltwomade.ToString();
        }
        private void totalthreeptattmpttxt_TextChanged(object sender, EventArgs e)
        {
            totalthreeptattmpttxt.Text = totalthreeattmpt.ToString();
        }

        private void totalthreeptmadetxt_TextChanged(object sender, EventArgs e)
        {
            totalthreeptmadetxt.Text = totalthreemade.ToString();
        }

        private void totalfshotattmpttxt_TextChanged(object sender, EventArgs e)
        {
            totalfshotattmpttxt.Text = totalfoulattmpt.ToString();
        }

        private void totalfshotmadetxt_TextChanged(object sender, EventArgs e)
        {
            totalfshotmadetxt.Text = totalfoulmade.ToString();
        }
        private void CalcTeamTotalsbtn_Click(object sender, EventArgs e)
        {
            /*twoattempttxt1.Text = "0"; twoattempttxt2.Text = "0"; twoattempttxt3.Text = "0"; twoattempttxt4.Text = "0"; twoattempttxt5.Text = "0"; twoattempttxt6.Text = "0";
            twoattempttxt7.Text = "0"; twoattempttxt8.Text = "0"; twoattempttxt9.Text = "0"; twoattempttxt10.Text = "0"; twoattempttxt11.Text = "0"; twoattempttxt12.Text = "0";
            twomadetxt1.Text = "0"; twomadetxt2.Text = "0"; twomadetxt3.Text = "0"; twomadetxt4.Text = "0"; twomadetxt5.Text = "0"; twomadetxt6.Text = "0";
            twomadetxt7.Text = "0"; twomadetxt8.Text = "0"; twomadetxt9.Text = "0"; twomadetxt10.Text = "0"; twomadetxt11.Text = "0"; twomadetxt12.Text = "0";
            threeattempttxt1.Text = "0"; threeattempttxt2.Text = "0"; threeattempttxt3.Text = "0"; threeattempttxt4.Text = "0"; threeattempttxt5.Text = "0"; threeattempttxt6.Text = "0";
            threeattempttxt7.Text = "0"; threeattempttxt8.Text = "0"; threeattempttxt9.Text = "0"; threeattempttxt10.Text = "0"; threeattempttxt11.Text = "0"; threeattempttxt12.Text = "0";
            threemadetxt1.Text = "0"; threemadetxt2.Text = "0"; threemadetxt3.Text = "0"; threemadetxt4.Text = "0"; threemadetxt5.Text = "0"; threemadetxt6.Text = "0";
            threemadetxt7.Text = "0"; threemadetxt8.Text = "0"; threemadetxt9.Text = "0"; threemadetxt10.Text = "0"; threemadetxt11.Text = "0"; threemadetxt12.Text = "0";

            flattmpttxt1.Text = "0"; flattmpttxt2.Text = "0"; flattmpttxt3.Text = "0"; flattmpttxt4.Text = "0"; flattmpttxt5.Text = "0"; flattmpttxt6.Text = "0";
            flattmpttxt7.Text = "0"; flattmpttxt8.Text = "0"; flattmpttxt9.Text = "0"; flattmpttxt10.Text = "0"; flattmpttxt11.Text = "0"; flattmpttxt12.Text = "0";
            flamdettxt1.Text = "0"; flamdettxt2.Text = "0"; flamdettxt3.Text = "0"; flamdettxt4.Text = "0"; flamdettxt5.Text = "0"; flamdettxt6.Text = "0";
            flamdettxt7.Text = "0"; flamdettxt8.Text = "0"; flamdettxt9.Text = "0"; flamdettxt10.Text = "0"; flamdettxt11.Text = "0"; flamdettxt12.Text = "0";*/
            totaltwoattmpt = totalthreeattmpt = totalfoulattmpt = totalassist = totaldeflectfst = totaldefreb = totaloffreb = 0;
            totaltwomade = totalthreemade = totalfoulmade = totalturnover = totaldeflectsnd = 0;


            int k = 12;
            for (int i = 0; i < k; i++) {
                totaltwoattmpt += twonumattempt1[i] + twonummade[i];
                totaltwomade += twonummade[i];
                totalthreeattmpt += threenumattempt1[i] + threenummade[i];
                totalthreemade += threenummade[i];
                totalfoulattmpt += foulnumattempt[i] + foulnummade[i];
                totalfoulmade += foulnummade[i];
                totalassist += assistnum[i];
                totalturnover += turnovernum[i];
                totaloffreb += offrebnum[i];
                totaldefreb += defrebnum[i];
                totaldeflectfst += deflectfstnum[i];
                totaldeflectsnd += deflectsndnum[i];

            }
        
            totaltwoptattmpttxt.Text = (totaltwoattmpt.ToString());

            totaltwoptmadetxt.Text = (totaltwomade.ToString());

            totalthreeptattmpttxt.Text = (totalthreeattmpt.ToString());

            totalthreeptmadetxt.Text = (totalthreemade.ToString());

            totalfshotattmpttxt.Text = (totalfoulattmpt.ToString());

            totalfshotmadetxt.Text = (totalfoulmade.ToString());

            totalassisttxt.Text = totalassist.ToString();

            totalturnovertxt.Text = totalturnover.ToString();

            totaloffrebtxt.Text = totaloffreb.ToString();

            totaldefrebtxt.Text = totaldefreb.ToString();

            totaldeflectfsttxt.Text = totaldeflectfst.ToString();

            totaldeflectsndtxt.Text = totaldeflectsnd.ToString();

            totalTwoPtPerctxt.Text = ((totaltwomade / totaltwoattmpt) * 100).ToString("#.##");
            totalThreePtPerctxt.Text = ((totalthreemade / totalthreeattmpt) * 100).ToString("#.##");
            totalFoulShotPerctxt.Text = ((totalfoulmade / totalfoulattmpt) * 100).ToString("#.##");
            HHScoretxt.Text = ((totaltwomade * 2) + (totalthreemade * 3) + (totalfoulmade * 1)).ToString();
        }

        /*----------------------------------------------- TOTAL TIMES PER PLAYER -----------------------------------------------------------------------*/

        private void CalcTimebtn1_Click(object sender, EventArgs e)
        {
            //outtxt1.Text = outtxt2.Text = outtxt3.Text = outtxt4.Text = outtxt5.Text = outtxt6.Text = "0:00";
            //intxt1.Text = intxt2.Text = intxt3.Text = intxt4.Text = intxt5.Text = intxt6.Text = "0:00";

            totalplayertime[0] = (TimeSpan.Parse(intxt1.Text + 0) - TimeSpan.Parse(outtxt1.Text + 0)) + (TimeSpan.Parse(intxt2.Text + 0) - TimeSpan.Parse(outtxt2.Text + 0)) + (TimeSpan.Parse(intxt3.Text + 0) - TimeSpan.Parse(outtxt3.Text + 0)) +
                (TimeSpan.Parse(intxt4.Text + 0) - TimeSpan.Parse(outtxt4.Text + 0)) + (TimeSpan.Parse(intxt5.Text + 0) - TimeSpan.Parse(outtxt5.Text + 0)) + (TimeSpan.Parse(intxt6.Text + 0) - TimeSpan.Parse(outtxt6.Text + 0));
            totaltimetxt1.Text = totalplayertime[0].ToString() ;
        }

        

        private void CalcTimebtn2_Click(object sender, EventArgs e)
        {
            totalplayertime[1] = (TimeSpan.Parse(intxt8.Text + 0) - TimeSpan.Parse(outtxt8.Text + 0)) + (TimeSpan.Parse(intxt9.Text + 0) - TimeSpan.Parse(outtxt9.Text + 0)) + (TimeSpan.Parse(intxt10.Text + 0) - TimeSpan.Parse(outtxt10.Text + 0)) +
               (TimeSpan.Parse(intxt11.Text + 0) - TimeSpan.Parse(outtxt11.Text + 0)) + (TimeSpan.Parse(intxt12.Text + 0) - TimeSpan.Parse(outtxt12.Text + 0)) + (TimeSpan.Parse(intxt13.Text + 0) - TimeSpan.Parse(outtxt13.Text + 0));
            totaltimetxt2.Text = totalplayertime[1].ToString();
        }

       

        private void CalcTimebtn3_Click(object sender, EventArgs e)
        {
            totalplayertime[2] = (TimeSpan.Parse(intxt15.Text + 0) - TimeSpan.Parse(outtxt15.Text + 0)) + (TimeSpan.Parse(intxt16.Text + 0) - TimeSpan.Parse(outtxt16.Text + 0)) + (TimeSpan.Parse(intxt17.Text + 0) - TimeSpan.Parse(outtxt17.Text + 0)) +
               (TimeSpan.Parse(intxt18.Text + 0) - TimeSpan.Parse(outtxt18.Text + 0)) + (TimeSpan.Parse(intxt19.Text + 0) - TimeSpan.Parse(outtxt19.Text + 0)) + (TimeSpan.Parse(intxt20.Text + 0) - TimeSpan.Parse(outtxt20.Text + 0));
            totaltimetxt3.Text = totalplayertime[2].ToString();
        }

        private void CalcTimebtn4_Click(object sender, EventArgs e)
        {
            totalplayertime[3] = (TimeSpan.Parse(intxt22.Text + 0) - TimeSpan.Parse(outtxt22.Text + 0)) + (TimeSpan.Parse(intxt23.Text + 0) - TimeSpan.Parse(outtxt23.Text + 0)) + (TimeSpan.Parse(intxt24.Text + 0) - TimeSpan.Parse(outtxt24.Text + 0)) +
               (TimeSpan.Parse(intxt25.Text + 0) - TimeSpan.Parse(outtxt25.Text + 0)) + (TimeSpan.Parse(intxt26.Text + 0) - TimeSpan.Parse(outtxt26.Text + 0)) + (TimeSpan.Parse(intxt27.Text + 0) - TimeSpan.Parse(outtxt27.Text + 0));
            totaltimetxt4.Text = totalplayertime[3].ToString();
        }

        

        private void CalcTimebtn5_Click(object sender, EventArgs e)
        {
            totalplayertime[4] = (TimeSpan.Parse(intxt29.Text + 0) - TimeSpan.Parse(outtxt29.Text + 0)) + (TimeSpan.Parse(intxt30.Text + 0) - TimeSpan.Parse(outtxt30.Text + 0)) + (TimeSpan.Parse(intxt31.Text + 0) - TimeSpan.Parse(outtxt31.Text + 0)) +
               (TimeSpan.Parse(intxt32.Text + 0) - TimeSpan.Parse(outtxt32.Text + 0)) + (TimeSpan.Parse(intxt33.Text + 0) - TimeSpan.Parse(outtxt33.Text + 0)) + (TimeSpan.Parse(intxt34.Text + 0) - TimeSpan.Parse(outtxt34.Text + 0));
            totaltimetxt5.Text = totalplayertime[4].ToString();
        }

       

        private void CalcTimebtn6_Click(object sender, EventArgs e)
        {
            totalplayertime[5] = (TimeSpan.Parse(intxt36.Text + 0) - TimeSpan.Parse(outtxt36.Text + 0)) + (TimeSpan.Parse(intxt37.Text + 0) - TimeSpan.Parse(outtxt37.Text + 0)) + (TimeSpan.Parse(intxt38.Text + 0) - TimeSpan.Parse(outtxt38.Text + 0)) +
               (TimeSpan.Parse(intxt39.Text + 0) - TimeSpan.Parse(outtxt39.Text + 0)) + (TimeSpan.Parse(intxt40.Text + 0) - TimeSpan.Parse(outtxt40.Text + 0)) + (TimeSpan.Parse(intxt41.Text + 0) - TimeSpan.Parse(outtxt41.Text + 0));
            totaltimetxt6.Text = totalplayertime[5].ToString();
        }
        private void CalcTimebtn7_Click(object sender, EventArgs e)
        {
            totalplayertime[6] = (TimeSpan.Parse(intxt43.Text + 0) - TimeSpan.Parse(outtxt43.Text + 0)) + (TimeSpan.Parse(intxt44.Text + 0) - TimeSpan.Parse(outtxt44.Text + 0)) + (TimeSpan.Parse(intxt45.Text + 0) - TimeSpan.Parse(outtxt45.Text + 0)) +
               (TimeSpan.Parse(intxt46.Text + 0) - TimeSpan.Parse(outtxt46.Text + 0)) + (TimeSpan.Parse(intxt47.Text + 0) - TimeSpan.Parse(outtxt47.Text + 0)) + (TimeSpan.Parse(intxt48.Text + 0) - TimeSpan.Parse(outtxt48.Text + 0));
            totaltimetxt7.Text = totalplayertime[6].ToString();
        }
        private void CalcTimebtn8_Click(object sender, EventArgs e)
        {
            totalplayertime[7] = (TimeSpan.Parse(intxt50.Text + 0) - TimeSpan.Parse(outtxt50.Text + 0)) + (TimeSpan.Parse(intxt51.Text + 0) - TimeSpan.Parse(outtxt51.Text + 0)) + (TimeSpan.Parse(intxt52.Text + 0) - TimeSpan.Parse(outtxt52.Text + 0)) +
               (TimeSpan.Parse(intxt53.Text + 0) - TimeSpan.Parse(outtxt53.Text + 0)) + (TimeSpan.Parse(intxt54.Text + 0) - TimeSpan.Parse(outtxt54.Text + 0)) + (TimeSpan.Parse(intxt55.Text + 0) - TimeSpan.Parse(outtxt55.Text + 0));
            totaltimetxt8.Text = totalplayertime[7].ToString();
        }
        private void CalcTimebtn9_Click(object sender, EventArgs e)
        {
            totalplayertime[8] = (TimeSpan.Parse(intxt57.Text + 0) - TimeSpan.Parse(outtxt57.Text + 0)) + (TimeSpan.Parse(intxt58.Text + 0) - TimeSpan.Parse(outtxt58.Text + 0)) + (TimeSpan.Parse(intxt59.Text + 0) - TimeSpan.Parse(outtxt59.Text + 0)) +
               (TimeSpan.Parse(intxt60.Text + 0) - TimeSpan.Parse(outtxt60.Text + 0)) + (TimeSpan.Parse(intxt61.Text + 0) - TimeSpan.Parse(outtxt61.Text + 0)) + (TimeSpan.Parse(intxt62.Text + 0) - TimeSpan.Parse(outtxt62.Text + 0));
            totaltimetxt9.Text = totalplayertime[8].ToString();
        }
        private void CalcTimebtn10_Click(object sender, EventArgs e)
        {
            totalplayertime[9] = (TimeSpan.Parse(intxt64.Text + 0) - TimeSpan.Parse(outtxt64.Text + 0)) + (TimeSpan.Parse(intxt65.Text + 0) - TimeSpan.Parse(outtxt65.Text + 0)) + (TimeSpan.Parse(intxt66.Text + 0) - TimeSpan.Parse(outtxt66.Text + 0)) +
               (TimeSpan.Parse(intxt67.Text + 0) - TimeSpan.Parse(outtxt67.Text + 0)) + (TimeSpan.Parse(intxt68.Text + 0) - TimeSpan.Parse(outtxt68.Text + 0)) + (TimeSpan.Parse(intxt69.Text + 0) - TimeSpan.Parse(outtxt69.Text + 0));
            totaltimetxt10.Text = totalplayertime[9].ToString();
        }
        private void CalcTimebtn11_Click(object sender, EventArgs e)
        {
            totalplayertime[10] = (TimeSpan.Parse(intxt71.Text + 0) - TimeSpan.Parse(outtxt71.Text + 0)) + (TimeSpan.Parse(intxt72.Text + 0) - TimeSpan.Parse(outtxt72.Text + 0)) + (TimeSpan.Parse(intxt73.Text + 0) - TimeSpan.Parse(outtxt73.Text + 0)) +
               (TimeSpan.Parse(intxt74.Text + 0) - TimeSpan.Parse(outtxt74.Text + 0)) + (TimeSpan.Parse(intxt75.Text + 0) - TimeSpan.Parse(outtxt75.Text + 0)) + (TimeSpan.Parse(intxt76.Text + 0) - TimeSpan.Parse(outtxt76.Text + 0));
            totaltimetxt11.Text = totalplayertime[10].ToString();
        }
        private void CalcTimebtn12_Click(object sender, EventArgs e)
        {
            totalplayertime[11] = (TimeSpan.Parse(intxt78.Text + 0) - TimeSpan.Parse(outtxt78.Text + 0)) + (TimeSpan.Parse(intxt79.Text + 0) - TimeSpan.Parse(outtxt79.Text + 0)) + (TimeSpan.Parse(intxt80.Text + 0) - TimeSpan.Parse(outtxt80.Text + 0)) +
               (TimeSpan.Parse(intxt81.Text + 0) - TimeSpan.Parse(outtxt81.Text + 0)) + (TimeSpan.Parse(intxt82.Text + 0) - TimeSpan.Parse(outtxt82.Text + 0)) + (TimeSpan.Parse(intxt83.Text + 0) - TimeSpan.Parse(outtxt83.Text + 0));
            totaltimetxt12.Text = totalplayertime[11].ToString();
        }

        /*----------------- INSERT TEAM CODE ---------------*/

        private void HHTeamCodetxt_TextChanged(object sender, EventArgs e)
        {
            teamCode = HHTeamCodetxt.Text;
        }
        /*-------------------------- GENERATE DATE AND TIME ----------------------------*/
        private void GameDatetxt_TextChanged(object sender, EventArgs e)
        {
            GameDatetxt.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void GameTimetxt_TextChanged(object sender, EventArgs e)
        {

            GameTimetxt.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
       
        /*----------------------------- SAVE FILE DIALOG -----------------------------------*/
        private void savebtn_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            // Get file name
            string format = "{0,18}";
            string name = saveFileDialog1.FileName;
            //Write to the file name selected.
            // ... You can write the text from a TextBox instead of a string literal
            File.WriteAllText(name + HHTeamCodetxt.Text + ".txt", "TOURNAMENT:  " + TournamentNametxt.Text + "    DATE:  " + GameDatetxt.Text + "    TIME:  " + GameTimetxt.Text
                + "\r\n\r\n" + "TEAM: HAWK HOOPS " + HHTeamCodetxt.Text + "    " + HHScoretxt.Text
                + "\r\n\r\n" + "OPP: " + OPPNametxt.Text + "    " + OPPScoretxt.Text
                + "\r\n\r\n" + "#" + "PLYRS" + String.Format(format,"2PTA") + " " + "2PTM" + " "
                + "3PTA" + " " + "3PTM" + " " + "FLA" + " " + "FLM" + " "
                + "AST" + " " + "TNVR" + " " + "OREB" + " " + "DREB" + " "
                + "DFCT1" + " " + "DFCT2" +
                " \r\n\r\n" + textBox1.Text + nametxt1.Text +  String.Format("{0,6}",twoattempttxt1.Text) + "    " + twomadetxt1.Text + "    " + threeattempttxt1.Text + "    " + threemadetxt1.Text + "   "
                + flattmpttxt1.Text + "    " + flamdettxt1.Text + "    " + assisttxt1.Text + "   " + turnovertxt1.Text + "     " + offrebtxt1.Text + "     " + defrebtxt1.Text
                + "   " + deflfsttxt1.Text + "   " + deflsndtxt1.Text +
                " \r\n" + textBox2.Text + nametxt2.Text + String.Format("{0,6}", twoattempttxt2.Text) + "    " + twomadetxt2.Text + "    " + threeattempttxt2.Text + "    " + threemadetxt2.Text + "   "
                + flattmpttxt2.Text + "    " + flamdettxt2.Text + "    " + assisttxt2.Text + "   " + turnovertxt2.Text + "     " + offrebtxt2.Text + "     " + defrebtxt2.Text
                + "   " + deflfsttxt2.Text + "   " + deflsndtxt2.Text +
                " \r\n" + textBox3.Text + nametxt3.Text + String.Format("{0,6}", twoattempttxt3.Text) + "    " + twomadetxt3.Text + "    " + threeattempttxt3.Text + "    " + threemadetxt3.Text + "   "
                + flattmpttxt3.Text + "    " + flamdettxt3.Text + "    " + assisttxt3.Text + "   " + turnovertxt3.Text + "     " + offrebtxt3.Text + "     " + defrebtxt3.Text
                + "   " + deflfsttxt3.Text + "   " + deflsndtxt3.Text +
                " \r\n" + textBox4.Text + nametxt4.Text + String.Format("{0,6}", twoattempttxt4.Text) + "    " + twomadetxt4.Text + "    " + threeattempttxt4.Text + "    " + threemadetxt4.Text + "   "
                + flattmpttxt4.Text + "    " + flamdettxt4.Text + "    " + assisttxt4.Text + "   " + turnovertxt4.Text + "     " + offrebtxt4.Text + "     " + defrebtxt4.Text
                + "   " + deflfsttxt4.Text + "   " + deflsndtxt4.Text +
                " \r\n" + textBox5.Text + nametxt5.Text + String.Format("{0,6}", twoattempttxt5.Text) + "    " + twomadetxt5.Text + "    " + threeattempttxt5.Text + "    " + threemadetxt5.Text + "   "
                + flattmpttxt5.Text + "    " + flamdettxt5.Text + "    " + assisttxt5.Text + "   " + turnovertxt5.Text + "     " + offrebtxt5.Text + "     " + defrebtxt5.Text
                + "   " + deflfsttxt5.Text + "   " + deflsndtxt5.Text +
                " \r\n" + textBox6.Text + nametxt6.Text + String.Format("{0,6}", twoattempttxt6.Text) + "    " + twomadetxt6.Text + "    " + threeattempttxt6.Text + "    " + threemadetxt6.Text + "   "
                + flattmpttxt6.Text + "    " + flamdettxt6.Text + "    " + assisttxt6.Text + "   " + turnovertxt6.Text + "     " + offrebtxt6.Text + "     " + defrebtxt6.Text
                + "   " + deflfsttxt6.Text + "   " + deflsndtxt6.Text +
                " \r\n" + textBox7.Text + nametxt7.Text + String.Format("{0,6}", twoattempttxt7.Text) + "    " + twomadetxt7.Text + "    " + threeattempttxt7.Text + "    " + threemadetxt7.Text + "   "
                + flattmpttxt7.Text + "    " + flamdettxt7.Text + "    " + assisttxt7.Text + "   " + turnovertxt7.Text + "     " + offrebtxt7.Text + "     " + defrebtxt7.Text
                + "   " + deflfsttxt7.Text + "   " + deflsndtxt7.Text +
                " \r\n" + textBox8.Text + nametxt8.Text + String.Format("{0,6}", twoattempttxt8.Text) + "    " + twomadetxt8.Text + "    " + threeattempttxt8.Text + "    " + threemadetxt8.Text + "   "
                + flattmpttxt8.Text + "    " + flamdettxt8.Text + "    " + assisttxt8.Text + "   " + turnovertxt8.Text + "     " + offrebtxt8.Text + "     " + defrebtxt8.Text
                + "   " + deflfsttxt1.Text + "   " + deflsndtxt1.Text +
                " \r\n" + textBox9.Text + nametxt9.Text + String.Format("{0,6}", twoattempttxt9.Text) + "    " + twomadetxt9.Text + "    " + threeattempttxt9.Text + "    " + threemadetxt9.Text + "   "
                + flattmpttxt9.Text + "    " + flamdettxt9.Text + "    " + assisttxt9.Text + "   " + turnovertxt9.Text + "     " + offrebtxt9.Text + "     " + defrebtxt9.Text
                + "   " + deflfsttxt9.Text + "   " + deflsndtxt9.Text +
                " \r\n" + textBox10.Text + nametxt10.Text + String.Format("{0,6}", twoattempttxt10.Text) + "    " + twomadetxt10.Text + "    " + threeattempttxt10.Text + "    " + threemadetxt10.Text + "   "
                + flattmpttxt10.Text + "    " + flamdettxt10.Text + "    " + assisttxt10.Text + "   " + turnovertxt10.Text + "     " + offrebtxt10.Text + "     " + defrebtxt10.Text
                + "   " + deflfsttxt10.Text + "   " + deflsndtxt10.Text +
                " \r\n" + textBox11.Text + nametxt11.Text + String.Format("{0,6}", twoattempttxt11.Text) + "    " + twomadetxt11.Text + "    " + threeattempttxt11.Text + "    " + threemadetxt11.Text + "   "
                + flattmpttxt11.Text + "    " + flamdettxt11.Text + "    " + assisttxt11.Text + "   " + turnovertxt11.Text + "     " + offrebtxt11.Text + "     " + defrebtxt11.Text
                + "   " + deflfsttxt11.Text + "   " + deflsndtxt11.Text +
                " \r\n" + textBox12.Text + nametxt12.Text + String.Format("{0,6}", twoattempttxt12.Text) + "    " + twomadetxt12.Text + "    " + threeattempttxt12.Text + "    " + threemadetxt12.Text + "   "
                + flattmpttxt12.Text + "    " + flamdettxt12.Text + "    " + assisttxt12.Text + "   " + turnovertxt12.Text + "     " + offrebtxt12.Text + "     " + defrebtxt12.Text
                + "   " + deflfsttxt12.Text + "   " + deflsndtxt12.Text
                + "\r\n\r\n\r\n" + "TEAM TOTALS: " + "T2PTA " + "T2PTM " + "T3PTA " + "T3PTM " + "TFLA " + "TFLM " + "TASST " + "TTNVR " + "TOREB " + "TDREB " + "TDFL1 " + "TDFL2"
                + "\r\n" + String.Format("{0,14 }", totaltwoptattmpttxt.Text) + "    " + totaltwoptmadetxt.Text + "    " + totalthreeptattmpttxt.Text + "    " + totalthreeptmadetxt.Text
                + "   " + totalfshotattmpttxt.Text + " " + totalfshotmadetxt.Text + "    " + totalassisttxt.Text + "    " + totalturnovertxt.Text + "    " + totaloffrebtxt.Text + "    "
                + totaldefrebtxt.Text + "    " + totaldeflectfsttxt.Text + "     " + totaldeflectsndtxt.Text
                + "\r\n\r\nTEAM 2PT SHOOTING %:  " + totalTwoPtPerctxt.Text + "%     TEAM 3PT SHOOTING %:  " + totalThreePtPerctxt.Text + "%     TEAM FOUL SHOOTING %:  " + totalFoulShotPerctxt.Text + "%");
        }










        /*-------------------------------------------------------------------- END OF PLAYER12 ------------------------------------------------------------------*/
    }
}
//public static void display() {
    
//}
