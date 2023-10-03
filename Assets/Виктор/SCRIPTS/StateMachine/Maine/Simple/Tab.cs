using UnityEngine;

public class Tab
{
    public string Name { get; private set; }
    public Component[] Components { get; private set; }

    public Tab(string name, Component[] Components)
    {
        Name = name;
    }

    public void HideComponents(HideFlags hideFlag)
    {
        foreach (Component component in Components)
            component.hideFlags = hideFlag;
    }
}