	public static long [] rechercheDiviseur (long _unNombre)
	{
		long [] mesDiviseurs= new long[100];
		int compteurCase=0;
		{

		/* de int i = 2 jusqu'a i < _unNombre */
		for (int i = 2; i < _unNombre ; i++) {

			/* modulo */	
			if (_unNombre%i==0)  {

				mesDiviseurs[compteurCase]=i;
				compteurCase++;

			}

			return mesDiviseurs;

		}
	}
	}