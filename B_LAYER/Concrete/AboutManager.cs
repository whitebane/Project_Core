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
	public class AboutManager : IAboutService
	{
		IAboutDL aboutDL;

		public AboutManager(IAboutDL aboutDL)
		{
			this.aboutDL = aboutDL;
		}

		public List<About> GetAll()
		{
			return aboutDL.GetAll();
		}
	}
}
