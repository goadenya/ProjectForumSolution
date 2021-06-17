using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgoraFE.Services
{
    public interface IMaintanable<T>
    {
        string Create(T obj);
        T Retrieve(string key);
        void Update(T obj);
        void Delete(string key);
    }
}
