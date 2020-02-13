using System;
using System.Collections.Generic;
using System.Linq;

namespace Payments.Domain.Entities
{
    public abstract class EntityBase
    {
        private List<string> _validationMessages { get; set; }
        private List<string> ValidationMessage
        {
            get { return _validationMessages ?? (_validationMessages = new List<string>()); }
        }
        protected bool IsValid
        {
            get { return !ValidationMessage.Any(); }
        }
        protected void ClearValidationMessages()
        {
            ValidationMessage.Clear();
        }
        protected void AddValidationMessage(string message)
        {
            ValidationMessage.Add(message);
        }
        public abstract void Validate();

    }
}
