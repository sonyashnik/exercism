using System;
using System.Collections.Generic;
using System.Linq;

public class CircularBuffer<T>
{
    private readonly int _capacity;
    private List<T> _buffer;

    public CircularBuffer(int capacity)
    {
        _capacity = capacity;
        _buffer = new List<T>(capacity);
    }
    private void Shift() => _buffer = _buffer.Skip(1).ToList();
    public T Read()
    {
        if (_buffer.Count() == 0)
        {
            throw new InvalidOperationException("Cannot read from empty buffer");
        }
        else 
        {
            T value = _buffer[0];
            Shift();
            return value;
        } 
    }

        public void Write(T value)
        {
            if (_buffer.Count() != _capacity)
            {
                _buffer.Add(value);
            }
            else
            {
                throw new InvalidOperationException("Cannot write to full buffer");
            }
        }

        public void Overwrite(T value)
        {
            if (_buffer.Count() == _capacity) Shift();
            _buffer.Add(value);
        }

        public void Clear()
        {
            _buffer.Clear();
        }
    }