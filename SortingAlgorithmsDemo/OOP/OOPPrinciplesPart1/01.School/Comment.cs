using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Comment
    {
        private ICollection<Comment> _comments;

        public Comment()
        {
            this._comments = new HashSet<Comment>();
        }

        public ICollection<Comment> Comments
        {
            get { return _comments; }
        }

        public void AddComment(Comment comment)
        {
            if (!this.Comments.Contains(comment))
            {
                this._comments.Add(comment);
            }
            
        }

        public void RemoveComment(Comment comment)
        {
            if (this._comments.Contains(comment))
            {
                _comments.Remove(comment);
            }
        }
        public void ClearAllComments()
        {
            this._comments.Clear();
        }
       
    }
}
