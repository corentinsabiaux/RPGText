using System;

public abstract class State
{
    public abstract State HandleInput(Player player, Input input);
}
