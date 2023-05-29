using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Pong
{
    public partial class Statistics : Form
    {
        List<Player> _player = new List<Player>();

        public Statistics()
        {
            InitializeComponent();

            LoadTopScoreFromCSV();
            ShowTopPlayers();
        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadTopScoreFromCSV()
        {
            //path from .exe file to Resources
            string filePath = "..\\..\\Resources\\Score.csv";

            var reader = new StreamReader(filePath);

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = Array.Empty<string>();
                if (!string.IsNullOrEmpty(line))
                {
                    values = line.Split(';');

                    Player plr = new Player();
                    plr.Name = values[0];
                    plr.Time = int.Parse(values[1]);
                    plr.Date = values[2];

                    _player.Add(plr);
                }
            }
        }

        private void ShowTopPlayers()
        {
            if ( _player.Count > 0 )
            {
                var top = _player.OrderBy(x => x.Time).Take(3).ToArray();
                winner1.Text = top[0].Name; 
                winner1more.Text = top[0].GetPlayerInfoWithoutName();
                if (top.Length > 1)
                {
                    winner2.Text = top[1].Name;
                    winner2more.Text = top[1].GetPlayerInfoWithoutName();
                }                 
                
                if (top.Length > 2)
                {
                    winner3.Text = top[2].Name;
                    winner3more.Text = top[2].GetPlayerInfoWithoutName();
                }
                    
            }
        }
    }
}
