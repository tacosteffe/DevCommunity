using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnDOP.Uses
{
    /// <summary>
    /// Heap, Stack
    /// Allocation
    /// 
    /// Memory Management
    /// Pointers, references
    /// </summary>
    /// 


    /* STACK
    Last in First out data structure
    Data can only be added and deleted from the top
    
    How is it allocated?
    Static allocation, unresizable, stored directly
    Allocated per thread and can only be accessed by that thread


    What lands on the stack?
    Value types (System.ValueType)
    struct, bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, uint, ulong, ushort
     
    --Stackoverflow--
    Stack is exhausted

    Access Speed: Fast

    Memory is freed upon exit of scope
     */



    /* HEAP
    Chunk data structure
    Data can be stored & removed in any order 

    How is it allocated?
    Dynamic allocation, resizable, stored indirectly
    Reference on stack, object on heap
    Can be accessed / visible to all threads

    What lands on the stack?
    Object types:
    class, interface, delegate, object, string


    Access Speed: Slow


    Memory is freed by the garbage collector
    (.Net thread that monitors allocations made on the heap)
     */




  


}
