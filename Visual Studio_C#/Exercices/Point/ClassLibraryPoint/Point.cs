using System;

namespace ClassLibraryPoint
{
    // Class
    public class Point
    {
        // Attributes
        private string pointNum;
        private float abscisseX;
        private float ordonneeY;

        // Properties
        public string PointNum
        {
            get { return pointNum; }
            set { pointNum = value; }
        }
        public float AbscisseX
        {
            get { return abscisseX; }
            set { abscisseX = value; }
        }
        public float OrdonneeY
        {
            get { return ordonneeY; }
            set { ordonneeY = value; }
        }

        // Constructors

        // Se construire soit sans information ( point 0,0 ), ou avec une valeur pour chaque coordonnées.
        public Point()
        {
            this.pointNum = "Unknow";
            this.abscisseX = 0;
            this.ordonneeY = 0;
        }
        public Point(float _abscisseX, float _ordonneeY)
        {
            this.abscisseX = _abscisseX;
            this.ordonneeY = _ordonneeY;
        }
        // Indiquer sa position ( abscisse et ordonnée ).
        public Point(string _pointNum, float _abscisseX, float _ordonneeY)
        {
            this.pointNum = _pointNum;
            this.abscisseX = _abscisseX;
            this.ordonneeY = _ordonneeY;
        }
        // Methods

        // Renvoyer une représentation textuelle en indiquant les valeurs de ses coordonnées.
        public override string ToString()
        {
            return "L'emplacement du " + pointNum + " est aux coordonnées : \nAbscisseX : " + abscisseX + "\nOrdonneeY : " + ordonneeY;
        }
        // Se déplacer en modifiant abscisse et ordonnée.
        public void Deplacer(float _abscisseX, float _ordonneeY)
        {
            abscisseX += _abscisseX;
            ordonneeY += _ordonneeY;
        }
        //Construire un point symétrique par rapport à l'axe des ordonnées.
        public Point SymetrieAxeOrdonnee()
        {
            return new Point(-abscisseX, ordonneeY);
        }
        public Point SymetrieAxeAbscisse()
        {
            return new Point(abscisseX, -ordonneeY);
        }
        public Point SymetrieOrigine()
        {
            return new Point(-abscisseX, -ordonneeY);
        }
        public void Permuter()
        {
            float temp = abscisseX;
            abscisseX = ordonneeY;
            ordonneeY = temp;
        }

        public static double MesureDistance(Point _pointA, Point _pointB)
        {
            return Math.Round(Math.Sqrt(Math.Pow((_pointB.AbscisseX - _pointA.AbscisseX), 2) + Math.Pow((_pointB.OrdonneeY - _pointA.OrdonneeY), 2)),3); 
        }

    }
}
