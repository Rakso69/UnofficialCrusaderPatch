﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnofficialCrusaderPatch
{
    public abstract class ChangeEdit
    {
        public abstract bool Initialize(ChangeArgs args);
        public abstract void Activate(ChangeArgs args);

        ChangeHeader parent;
        public ChangeHeader Parent => parent;

        public virtual void SetParent(ChangeHeader parent)
        {
            this.parent = parent;
        }
    }
}
