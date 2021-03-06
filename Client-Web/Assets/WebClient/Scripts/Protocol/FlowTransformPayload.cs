using System;
using System.Collections.Generic;

[System.Serializable]
public class FlowTransformPayload : FlowPayload
{
    public new FlowTObject data;
    public FlowTransformPayload(FlowTObject init) {
        data = init;
    }
    public FlowTransformPayload(string _tid) {
        data = new FlowTObject(_tid);
    }
}
