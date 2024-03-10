using System.Collections;

public static class TakingTurns {
    public static void Test() {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        string person;
        // Console.WriteLine(players);    // This can be un-commented out for debug help
        while (players.GetNextPerson(out person)) {
            Console.WriteLine(person);
        }    
        
        // Defect(s) Found:


         
        //The error :The "Bob" person is not re-added to the queue after getting dequeued.
        //Expected Result :Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
       
           

        Console.WriteLine("---------");
       

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++) {
            players.GetNextPerson(out string p);
            Console.WriteLine(p);
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        // Console.WriteLine(players);
        while (players.GetNextPerson(out string p2)) {
            Console.WriteLine(p2); 
        }
           

        // Defect(s) Found: 

       

        Console.WriteLine("---------");

        //After adding George, the queue doesn't maintain turns properly.
        //Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George

    

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        players.AddPerson("Tim", -1); 
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: 

        Console.WriteLine("---------");
        //"Tim" with infinite turns (0) is not correctly handling, and it should be re-added to the queue.
        //Expected Result:Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim

         // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", -3);
        players.AddPerson("Sue", 3);
        players.AddPerson("Tim", -1); 
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: 

        Console.WriteLine("---------");
        //The handling of a person with infinite turns (-3) is not correct, and it should be re-added to the queue.
        //Expected Result:Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        //

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson();
        // Defect(s) Found:
        

        //No error handling for attempting to get the next person from an empty queue.

        
    }

}

