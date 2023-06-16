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
	public class WriterManager : IWriterService
	{
		IWriterDL _writerdl;

		public WriterManager(IWriterDL writerdl)
		{
			_writerdl = writerdl;
		}

		public void AddWriter(Writer writer)
		{
			_writerdl.Insert(writer);
		}
	}
}
