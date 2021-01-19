using System;

namespace CardsGame
{
    public interface ICard
    {
        string Code { get; }
        int StackOrder { get; set; }
        string Description { get; }
    }
}
