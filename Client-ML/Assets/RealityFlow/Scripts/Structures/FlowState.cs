using System;
using System.Collections.Generic;

[System.Serializable]
public class FlowState
{
    public String _id;
    public String _bid;
    [System.NonSerialized]
    public List<string> _instances;
    public String name;
    public String _parentState;
}