﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formall.Persistence
{
    using Formall.Linq;
    using Formall.Reflection;

    internal class Document : IEntity
    {
        private readonly DataRow _dataRow;

        public Document(DataRow dataRow)
        {
            _dataRow = dataRow;
        }

        protected DataRow DataRow
        {
            get { return _dataRow; }
        }

        #region - Document -

        dynamic IDocument.Content
        {
            get { throw new NotImplementedException(); }
        }

        IDocumentContext IDocument.Context
        {
            get { throw new NotImplementedException(); }
        }

        string IDocument.Key
        {
            get { throw new NotImplementedException(); }
        }

        Metadata IDocument.Metadata
        {
            get { throw new NotImplementedException(); }
        }

        #endregion - Document -

        public dynamic Content
        {
            get { throw new NotImplementedException(); }
        }

        public Guid Id
        {
            get { throw new NotImplementedException(); }
        }

        public Model Model
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository Repository
        {
            get { throw new NotImplementedException(); }
        }

        public IResult Delete()
        {
            throw new NotImplementedException();
        }

        public T Get<T>()
        {
            throw new NotImplementedException();
        }

        public IResult Refresh()
        {
            throw new NotImplementedException();
        }

        public IResult Set<T>(T value)
        {
            throw new NotImplementedException();
        }

        public IResult Patch(IDictionary data)
        {
            throw new NotImplementedException();
        }

        public IResult Update(IDictionary data)
        {
            throw new NotImplementedException();
        }
    }
}
