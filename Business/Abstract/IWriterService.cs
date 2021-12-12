using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IWriterService: IGenericService<Writer>
    {
        void WriterAdd(Writer writer);
    }
}
