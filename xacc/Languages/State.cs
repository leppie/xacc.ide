// Gardens Point Parser Generator (Runtime component)
// Copyright (c) Wayne Kelly, QUT 2005
// (see accompanying GPPGcopyright.rtf)


using System.Collections.Generic;


namespace gppg
{
  public class State
  {
    public int num;
    public Dictionary<int, int> parser_table;  // Terminal -> ParseAction
    public Dictionary<int, int> Goto;          // NonTerminal -> State;
    public int defaultAction = 0;			   // ParseAction


    public State(int[] actions, int[] gotos)
      : this(actions)
    {
      Goto = new Dictionary<int, int>(gotos.Length/2);
      for (int i = 0 ; i < gotos.Length ; i += 2)
        Goto.Add(gotos[i], gotos[i + 1]);
    }

    public State(int[] actions)
    {
      parser_table = new Dictionary<int, int>(actions.Length/2);
      for (int i = 0 ; i < actions.Length ; i += 2)
        parser_table.Add(actions[i], actions[i + 1]);
    }

    public State(int defaultAction)
    {
      this.defaultAction = defaultAction;
    }

    public State(int defaultAction, int[] gotos)
      : this(defaultAction)
    {
      Goto = new Dictionary<int, int>(gotos.Length/2);
      for (int i = 0 ; i < gotos.Length ; i += 2)
        Goto.Add(gotos[i], gotos[i + 1]);
    }
  }
}