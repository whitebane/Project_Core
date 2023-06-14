using E_LAYER.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_LAYER.Abstract
{
	public interface ICommentService
	{
		void AddComment(Comment comment);
		//void DeleteCategory(Comment comment);
		//void UpdateCategory(Comment comment);

		List<Comment> GetAll(int id);
		//Comment GetByID(int id);
	}
}
