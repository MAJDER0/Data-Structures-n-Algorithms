﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_n_Algorithms.Data_Structures.Linear_Data_Structure.Array
{
    public unsafe class Array : IDisposable
    {
        private int* _data;
        private int size;
        private bool _disposed = false;

        public Array(int size) {

            if (size <= 0)
                throw new ArgumentException("Size must be greater than zero");


            this.size = size;
            _data = (int*)Marshal.AllocHGlobal(sizeof(int) * this.size);

            for (int i = 0; i < this.size; i++)
            {
                _data[i] = 0;
            }
            
        }

        
        public int this[int index] 
        {

            get {
            
                if (index < 0 || index >= size)
                {
                    throw new ArgumentOutOfRangeException("Index is out of bounds");
                }

                return _data[index];

            }

            set {

                if (index < 0 || index >= size)
                {
                    throw new ArgumentOutOfRangeException("Index is out of bounds");
                }

                _data[index] = value;

            }
        
        }

        public int Size{
            get { return size; }
        }

        public void Dispose() {

            Dispose(true);
            GC.SuppressFinalize(this);
            
        }

        protected virtual void Dispose(bool disposing) {

            if (!_disposed) {

                Marshal.FreeHGlobal((IntPtr)_data);
                _data = null;

                _disposed = true;

            }
        }

        ~Array() {
            Dispose(false);
        }

    }
}