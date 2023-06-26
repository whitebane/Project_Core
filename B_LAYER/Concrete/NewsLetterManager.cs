using B_LAYER.Abstract;
using D_LAYER.Abstract;
using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_LAYER.Concrete
{
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDL _newsLetterDL;

		public NewsLetterManager(INewsLetterDL newsLetterDL)
		{
			_newsLetterDL = newsLetterDL;
		}

		public void AddNewsLetter(NewsLetter newsLetter)
		{
			_newsLetterDL.Insert(newsLetter);
		}

	}
}
