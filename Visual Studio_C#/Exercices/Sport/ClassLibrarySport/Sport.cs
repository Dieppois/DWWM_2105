using System;
////On doit pouvoir construire un objet 
// en ne connaissant que le nom du sport
// le type de sport peut-être indiqué ultérieurement.
//2. L'encapsulation doit être mise en œuvre.
//3. la méthode ToString() doit renvoyer :
// le nom du sport est 
// suivi du nom du sport
// suivi de ce sport a pour type
// suivi du contenu du type de sport.

namespace ClassLibrarySport
{
    public class Sport
    {
        private string strNomSport;
        protected string strTypeSport;
        public Sport()
        {
            string nomDuSport = Value;
            // TODO : implement code
        }
        public override string ToString()
        {
            return "Le nom du sport" + 
        }
    }
}
