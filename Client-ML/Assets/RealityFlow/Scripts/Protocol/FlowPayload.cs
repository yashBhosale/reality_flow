using System;
using System.Collections.Generic;

[System.Serializable]
public class FlowPayload
{
    public string data;
    public string _from;
    public FlowPayload() {

    }
    public FlowPayload(string _data) {
        data = _data;
    }
}