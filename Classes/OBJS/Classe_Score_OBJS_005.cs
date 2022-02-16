using System;

namespace CPV9.Classes
{
    class Classe_Score_OBJS_005
    {
        public int Scores_Joueur = 0;
        public int Score_ObjS { get; set; }

        private int Score = 0;
        private int _tr1 = 0;
        private int _tr2 = 0;
        private int _tr3 = 0;
        private int _tr4 = 0;
        private int _tr5 = 0;
        private int _TrT = 0;
        private int _ScoreBonus = 0;

        public Classe_Score_OBJS_005(String Saisie1, String Saisie2, String Saisie3, String Saisie4, String Saisie5)
        {
            if (Saisie1 != ""){_tr1 = Convert.ToInt32(Saisie1); };
            if (Saisie2 != ""){_tr2 = Convert.ToInt32(Saisie2); };
            if (Saisie3 != ""){_tr3 = Convert.ToInt32(Saisie3); };
            if (Saisie4 != ""){_tr4 = Convert.ToInt32(Saisie4); };
            if (Saisie5 != ""){_tr5 = Convert.ToInt32(Saisie5); };
            
            _TrT = _tr1 + _tr2 + _tr3 + _tr4 + _tr5;
            Score = Score + (_TrT / 10);
                
           if ( _TrT >= 50){ _ScoreBonus++; };
           if ( _TrT >= 99){ _ScoreBonus++; };

            Score_ObjS = Score + _ScoreBonus;
            if (Score >= 15)
            {
                Score = 15;
            }
            Scores_Joueur = Score;
        }

        public string Bonus { get { return Convert.ToString(_ScoreBonus); } }
        public string Cumul { get { return Convert.ToString(_TrT); } }
    }
}
