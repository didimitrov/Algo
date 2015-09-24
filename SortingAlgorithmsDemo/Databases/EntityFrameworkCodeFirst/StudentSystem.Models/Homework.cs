using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentSystem.Models
{
    public class Homework
    {
        private ICollection<Material> _materials;

        public Homework()
        {
            this.Materials = new HashSet<Material>();
        }
       
        public int HomeworkId { get; set; }
        public string Content { get; set; }
        public DateTime? TimeSent { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        public int StudenId { get; set; }
        public virtual Student Student { get; set; }

        public virtual ICollection<Material> Materials
        {
            get { return _materials; }
            set { _materials = value; }
        }
    }
}
