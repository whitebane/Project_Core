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
	public class CommentManager : ICommentService
	{
		ICommentDL commentDL;

		public CommentManager(ICommentDL commentDL)
		{
			this.commentDL = commentDL;
		}

		public void AddComment(Comment comment)
		{
		 commentDL.Insert(comment);
		}

		public List<Comment> GetAll(int id)
		{
			return commentDL.GetAll(p=>p.BlogID==id);
		}
	}
}
