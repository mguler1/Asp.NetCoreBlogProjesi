using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> ListAll(int id);
        void CommentAdd(Comment comment);
       // void CommentDelete(Comment comment);
        //void CommentUpdate(Comment comment);
      //  Comment GetById(int id);
    }
}
