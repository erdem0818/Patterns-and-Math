using UnityEngine;
using System.Collections.Generic;
using System.Collections;

//  GAME PROGRAMMING PATTERNS BOOK, GITHUB HABRADOR
public class GameController : MonoBehaviour
{
    [SerializeField] private MoveObject player;

    //Commands
    private Command buttonW;
    private Command buttonS;
    private Command buttonD;
    private Command buttonA;

    
    //store the commands
    private Stack<Command> undoCommands = new Stack<Command>();
    private Stack<Command> redoCommands = new Stack<Command>();

    private bool isReplaying = false;

    private Vector3 startPos;

    private const float replay_pause_timer = 0.5f;

    private void Start()
    {
        buttonW = new MoveForwardCommand(player);
        buttonS = new MoveBackCommand(player);
        buttonD = new MoveRightCommand(player);
        buttonA = new MoveLeftCommand(player);

        startPos = player.transform.position;
    }

    private void Update()
    {
        // We can check for input while we are replaying
        if (isReplaying) return;

        //We will here jump in steps to make the undo system easier
        //If we were moving with speed * Time.deltaTime, the undo system would be more comlicated to implement.
        //When we undo, the Time.deltaTime may be different so we end up at another position than we previously had
        //You could solve this by saving the Time.deltaTime somewhere

        //my suggestion is using fixedDeltaTime
        if (Input.GetKeyDown(KeyCode.W)) ExecuteNewCommand(buttonW);
        else if (Input.GetKeyDown(KeyCode.S)) ExecuteNewCommand(buttonS);
        else if (Input.GetKeyDown(KeyCode.D)) ExecuteNewCommand(buttonD);
        else if (Input.GetKeyDown(KeyCode.A)) ExecuteNewCommand(buttonA);
        else if(Input.GetKeyDown(KeyCode.U)) // <-- Undo with U
        {
            if(undoCommands.Count.Equals(0))
            {
                Debug.Log("Can't undo becaseu we are back where we started");
            }
            else
            {
                Command lastCommand = undoCommands.Pop();

                lastCommand.Undo();

                //Add this to redo if we want to redo the undo
                //Geri almayı yeniden yapmak istiyorsak bunu yeniden yapmak için ekleyin
                redoCommands.Push(lastCommand);
            }
        }
        else if(Input.GetKeyDown(KeyCode.R)) // <-- Redo with R
        {
            if(redoCommands.Count.Equals(0))
            {
                Debug.Log("Can't redo beacuse we are at the end");
            }
            else
            {
                Command nextCommand = redoCommands.Pop();

                nextCommand.Execute();

                //Add this to undo if we want to undo redo
                //Yinelemeyi geri almak istiyorsak bunu geri almak için ekleyin
                undoCommands.Push(nextCommand);
            }
        }     

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //ref is important or the keys will not be swapped
            SwapKeys(ref buttonA, ref buttonD);
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(Replay());

            isReplaying = true;
        }
    }

    private IEnumerator Replay()
    {
        //move the object back to where it started
        player.transform.position = startPos;

        //pause so we can see that it has started at the start position
        yield return new WaitForSeconds(replay_pause_timer);

        Command[] oldCommands = undoCommands.ToArray();

        //this array is inverted so we iterate from the back
        for(int i= oldCommands.Length - 1; i >= 0; i--)
        {
            Command currentCommand = oldCommands[i];

            currentCommand.Execute();

            yield return new WaitForSeconds(replay_pause_timer);
        }

        isReplaying = false;
    }

    //Will execute the command and do stuff to the list to make the replay, undo, redo system work
    private void ExecuteNewCommand(Command commandButton)
    {
        commandButton.Execute();

        //add the new command to stack in last position
        undoCommands.Push(commandButton);

        //Remove all redo commands because redo is not defined when we have add a new command !!!
        redoCommands.Clear();
    }

    private void SwapKeys(ref Command key1, ref Command key2)
    {
        Command temp = key1;

        key1 = key2;
        key2 = temp;
    }

}