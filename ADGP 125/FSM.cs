using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void callBack();

namespace FSM
{
    /// <summary>
    /// Making FSM Generic and not use void functions
    /// Must use Classes, enums, structs, Lists, Interfaces
    /// </summary>

    public class FSM<T>
    {
        public Dictionary<string, callBack> transactionTable = new Dictionary<string, callBack>(); // A dictionary of strings and a delegate named callBack.
        public List<T> gameState = new List<T>(); // Making a list to store information of T.
        private string keyName; // the keyName is for the Strings in the Dictionary
        public T currentState; // a public Template currentState


        public void addState(T state) // add States, let the user add the states and store them.
        {
            if (gameState.Contains(state)) // Checks if the state exist in the list
            {
                Debug.Print("Can't add the same state to the list"); // If the state exist, cout message
            }
            else
            {
                gameState.Add(state); // Add the state in the list
                                      //Debug.Log("This " + state + " has been added to this list");
            }
        }
        /*
            For What I understand so far. Delegates are used by a 'callBack' to exe whatever functions we pass into it. 
            First, we add the states, having both currentStates and nextStates as T's(templates). 
            adding the Transitions which have both states and the delegate that exe's all the functions that goes between those states.
        */
        public void addTransition(T currentState, T nextState, callBack del) // letting the user add transitions
        {
            if (gameState.Contains(currentState) && gameState.Contains(nextState)) // Checks if the current and nextState in the list
            {
                keyName = currentState.ToString() + "going to state: " + nextState.ToString(); // Putting the current and nextStates to strings because keyName is a string as well.
                transactionTable.Add(keyName, del); // adding the string and function into the dictonary.
                                                    //Debug.Log(currentState.ToString() + " Added transaction " + nextState.ToString());
            }

            else
            {
                Debug.Print("Couldn't add transaction, try again please");
            }
        }

        public void changingState(T nextState) // Changing the states
        {
            Transition(currentState, nextState);
        }

        private void Transition(T currentState, T nextState) // Checking the transitions
        {
            keyName = currentState.ToString() + "going to state " + nextState.ToString();
            callBack del;

            foreach (object o in transactionTable)
            {
                transactionTable.TryGetValue(keyName, out del);
                currentState = nextState;
                Debug.Print("Current state is: " + currentState.ToString());
            }
        }
    }
}
