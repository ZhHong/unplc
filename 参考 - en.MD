*Version 0.1.0*
*Build by ZhouHong*

*Copyright © 2017 Chongqing LongMao Information Technology Co., Ltd. All rights reserved*

# Appendix A

|Aug 2017|	Aug 2016|	Change|	Programming Language|	Ratings|	Change|
|:-------|:-------|:-------|:-------|:-------|:-------|
|1|1||Java|12.961%|-6.05%|
|2|2||C|6.477%|-4.83%|
|3|3||C++|5.550%|-0.25%|
|4|4||C#|4.195%|-0.71%|
|5|5||Python|3.692%|-0.71%|
|6|8|change|VisualBasic .NET|2.569%|	+0.05%|
|7|6|change|PHP|2.293%|	-0.88%|
|8|7|change|JavaScript|	2.098%|	-0.61%|
|9|9||Perl|1.995%|-0.52%|
|10|12|change|Ruby|1.965%|-0.31%|
|11|14|change|Swift|1.825%|	-0.16%|
|12|11|change|Delphi/Object Pascal|	1.825%|	-0.45%|
|13|13||Visual Basic|1.809%|-0.24%|
|14|10|change|Assembly language|1.805%|	-0.56%|
|15|17|change|R|1.766%|+0.16%|
|16|20|change|Go|1.645%|+0.37%|
|17|18|change|MATLAB|1.619%|+0.08%|
|18|15|change|Objective-C|1.505%|-0.38%|
|19|22|change|Scratch|1.481%|+0.43%|
|20|26|change|Dart|	1.273%|	+0.30%|

# Appendix B

## Data Structures
### Linked List
 * A *Linked List* is a linear collection of data elements, called nodes, each
   pointing to the next node by means of a pointer. It is a data structure
   consisting of a group of nodes which together represent a sequence.
 * **Singly-linked list**: linked list in which each node points to the next node and the last node points to null
 * **Doubly-linked list**: linked list in which each node has two pointers p, n such that p points to the previous node and n points to the next node; the last node's n pointer points to null
 * **Circular-linked list**: linked list in which each node points to the next node and the last node points back to the first node
 * Time Complexity:
   * Access: `O(n)`
   * Search: `O(n)`
   * Insert: `O(1)`
   * Remove: `O(1)`

### Stack
 * A *Stack* is a collection of elements, with two principle operations: *push*, which adds to the collection, and
   *pop*, which removes the most recently added element
 * Last in, first out data structure (LIFO)
 * Time Complexity:
  * Access: `O(n)`
  * Search: `O(n)`
  * Insert: `O(1)`
  * Remove: `O(1)`

### Queue
 * A *Queue* is a collection of elements, supporting two principle operations: *enqueue*, which inserts an element
   into the queue, and *dequeue*, which removes an element from the queue
 * First in, first out data structure (FIFO)
 * Time Complexity:
  * Access: `O(n)`
  * Search: `O(n)`
  * Insert: `O(1)`
  * Remove: `O(1)`

### Tree
 * A *Tree* is an undirected, connected, acyclic graph

### Binary Tree
 * A *Binary Tree* is a tree data structure in which each node has at most two children, which are referred to as
   the *left child* and *right child*
 * **Full Tree**: a tree in which every node has either 0 or 2 children
 * **Perfect Binary Tree**: a binary tree in which all interior nodes have two children and all leave have the same depth
 * **Complete Tree**: a binary tree in which every level *except possibly the last* is full and all nodes in the last
   level are as far left as possible

### Binary Search Tree
 * A binary search tree, sometimes called BST, is a type of binary tree which maintains the property that the value in each
   node must be greater than or equal to any value stored in the left sub-tree, and less than or equal to any value stored
   in the right sub-tree
 * Time Complexity:
  * Access: `O(log(n))`
  * Search: `O(log(n))`
  * Insert: `O(log(n))`
  * Remove: `O(log(n))`

<img src="/Images/BST.png?raw=true" alt="Binary Search Tree" width="400" height="500">

### Trie
* A trie, sometimes called a radix or prefix tree, is a kind of search tree that is used to store a dynamic set or associative
  array where the keys are usually Strings. No node in the tree stores the key associated with that node; instead, its position 
  in the tree defines the key with which it is associated. All the descendants of a node have a common prefix of the String associated 
  with that node, and the root is associated with the empty String.

![Alt text](/Images/trie.png?raw=true "Trie")

### Fenwick Tree
* A Fenwick tree, sometimes called a binary indexed tree, is a tree in concept, but in practice is implemented as an implicit data
  structure using an array. Given an index in the array representing a vertex, the index of a vertex's parent or child is calculated
  through bitwise operations on the binary representation of its index. Each element of the array contains the pre-calculated sum of
  a range of values, and by combining that sum with additional ranges encountered during an upward traversal to the root, the prefix
  sum is calculated
* Time Complexity:
 * Range Sum: `O(log(n))`
 * Update: `O(log(n))`

![Alt text](/Images/fenwickTree.png?raw=true "Fenwick Tree")

### Segment Tree
* A Segment tree, is a tree data structure for storing intervals, or segments. It allows querying which of the stored segments contain
  a given point
* Time Complexity:
 * Range Query: `O(log(n))`
 * Update: `O(log(n))`

![Alt text](/Images/segmentTree.png?raw=true "Segment Tree")

### Heap
* A *Heap* is a specialized tree based structure data structure that satisfies the *heap* property: if A is a parent node of
B, then the key (the value) of node A is ordered with respect to the key of node B with the same ordering applying across the entire heap.
A heap can be classified further as either a "max heap" or a "min heap". In a max heap, the keys of parent nodes are always greater
than or equal to those of the children and the highest key is in the root node. In a min heap, the keys of parent nodes are less than
or equal to those of the children and the lowest key is in the root node
* Time Complexity:
 * Access: `O(log(n))`
 * Search: `O(log(n))`
 * Insert: `O(log(n))`
 * Remove: `O(log(n))`
 * Remove Max / Min: `O(1)`

<img src="/Images/heap.png?raw=true" alt="Max Heap" width="400" height="500">


### Hashing
* *Hashing* is used to map data of an arbitrary size to data of a fixed size. The values return by a hash
  function are called hash values, hash codes, or simply hashes. If two keys map to the same value, a collision occurs
* **Hash Map**: a *hash map* is a structure that can map keys to values. A hash map uses a hash function to compute
  an index into an array of buckets or slots, from which the desired value can be found.
* Collision Resolution
 * **Separate Chaining**: in *separate chaining*, each bucket is independent, and contains a list of entries for each index. The
 time for hash map operations is the time to find the bucket (constant time), plus the time to iterate through the list
 * **Open Addressing**: in *open addressing*, when a new entry is inserted, the buckets are examined, starting with the
 hashed-to-slot and proceeding in some sequence, until an unoccupied slot is found. The name open addressing refers to
 the fact that the location of an item is not always determined by its hash value


![Alt text](/Images/hash.png?raw=true "Hashing")

### Graph
* A *Graph* is an ordered pair of G = (V, E) comprising a set V of vertices or nodes together with a set E of edges or arcs,
  which are 2-element subsets of V (i.e. an edge is associated with two vertices, and that association takes the form of the
  unordered pair comprising those two vertices)
 * **Undirected Graph**: a graph in which the adjacency relation is symmetric. So if there exists an edge from node u to node
 v (u -> v), then it is also the case that there exists an edge from node v to node u (v -> u)
 * **Directed Graph**: a graph in which the adjacency relation is not symmetric. So if there exists an edge from node u to node v
 (u -> v), this does *not* imply that there exists an edge from node v to node u (v -> u)


<img src="/Images/graph.png?raw=true" alt="Graph" width="400" height="500">

## Algorithms

### Sorting

#### Quicksort
* Stable: `No`
* Time Complexity:
 * Best Case: `O(nlog(n))`
 * Worst Case: `O(n^2)`
 * Average Case: `O(nlog(n))`

![Alt text](/Images/quicksort.gif?raw=true "Quicksort")

#### Mergesort
* *Mergesort* is also a divide and conquer algorithm. It continuously divides an array into two halves, recurses on both the
  left subarray and right subarray and then merges the two sorted halves
* Stable: `Yes`
* Time Complexity:
 * Best Case: `O(nlog(n))`
 * Worst Case: `O(nlog(n))`
 * Average Case: `O(nlog(n))`

![Alt text](/Images/mergesort.gif?raw=true "Mergesort")

#### Bucket Sort
* *Bucket Sort* is a sorting algorithm that works by distributing the elements of an array into a number of buckets. Each bucket
  is then sorted individually, either using a different sorting algorithm, or by recursively applying the bucket sorting algorithm
* Time Complexity:
 * Best Case: `Ω(n + k)`
 * Worst Case: `O(n^2)`
 * Average Case:`Θ(n + k)`

![Alt text](/Images/bucketsort.png?raw=true "Bucket Sort")

#### Radix Sort
* *Radix Sort* is a sorting algorithm that like bucket sort, distributes elements of an array into a number of buckets. However, radix
  sort differs from bucket sort by 're-bucketing' the array after the initial pass as opposed to sorting each bucket and merging
* Time Complexity:
 * Best Case: `Ω(nk)`
 * Worst Case: `O(nk)`
 * Average Case: `Θ(nk)`

### Graph Algorithms

#### Depth First Search
* *Depth First Search* is a graph traversal algorithm which explores as far as possible along each branch before backtracking
* Time Complexity: `O(|V| + |E|)`

![Alt text](/Images/dfsbfs.gif?raw=true "DFS / BFS Traversal")

#### Breadth First Search
* *Breadth First Search* is a graph traversal algorithm which explores the neighbor nodes first, before moving to the next
  level neighbors
* Time Complexity: `O(|V| + |E|)`

![Alt text](/Images/dfsbfs.gif?raw=true "DFS / BFS Traversal")

#### Topological Sort
* *Topological Sort* is the linear ordering of a directed graph's nodes such that for every edge from node u to node v, u
  comes before v in the ordering
* Time Complexity: `O(|V| + |E|)`

#### Dijkstra's Algorithm
* *Dijkstra's Algorithm* is an algorithm for finding the shortest path between nodes in a graph
* Time Complexity: `O(|V|^2)`

![Alt text](/Images/dijkstra.gif?raw=true "Dijkstra's")

#### Bellman-Ford Algorithm
* *Bellman-Ford Algorithm* is an algorithm that computes the shortest paths from a single source node to all other nodes in a weighted graph
* Although it is slower than Dijkstra's, it is more versatile, as it is capable of handling graphs in which some of the edge weights are
  negative numbers
* Time Complexity:
 * Best Case: `O(|E|)`
 * Worst Case: `O(|V||E|)`

![Alt text](/Images/bellman-ford.gif?raw=true "Bellman-Ford")

#### Floyd-Warshall Algorithm
* *Floyd-Warshall Algorithm* is an algorithm for finding the shortest paths in a weighted graph with positive or negative edge weights, but
  no negative cycles
* A single execution of the algorithm will find the lengths (summed weights) of the shortest paths between *all* pairs of nodes
* Time Complexity:
 * Best Case: `O(|V|^3)`
 * Worst Case: `O(|V|^3)`
 * Average Case: `O(|V|^3)`

#### Prim's Algorithm
* *Prim's Algorithm* is a greedy algorithm that finds a minimum spanning tree for a weighted undirected graph. In other words, Prim's find a
  subset of edges that forms a tree that includes every node in the graph
* Time Complexity: `O(|V|^2)`

![Alt text](/Images/prim.gif?raw=true "Prim's Algorithm")

#### Kruskal's Algorithm
* *Kruskal's Algorithm* is also a greedy algorithm that finds a minimum spanning tree in a graph. However, in Kruskal's, the graph does not
  have to be connected
* Time Complexity: `O(|E|log|V|)`

![Alt text](/Images/kruskal.gif?raw=true "Kruskal's Algorithm")

## Greedy Algorithms
* *Greedy Algorithms* are algorithms that make locally optimal choices at each step in the hope of eventually reaching the globally optimal solution
* Problems must exhibit two properties in order to implement a Greedy solution:
 * Optimal Substructure
    * An optimal solution to the problem contains optimal solutions to the given problem's subproblems
 * The Greedy Property
    * An optimal solution is reached by "greedily" choosing the locally optimal choice without ever reconsidering previous choices
* Example - Coin Change
    * Given a target amount V cents and a list of denominations of n coins, i.e. we have coinValue[i] (in cents) for coin types i from [0...n - 1],
      what is the minimum number of coins that we must use to represent amount V? Assume that we have an unlimited supply of coins of any type
    * Coins - Penny (1 cent), Nickel (5 cents), Dime (10 cents), Quarter (25 cents)
    * Assume V = 43. We can use the Greedy algorithm of continuously selecting the largest coin denomination less than or equal to V, subtract that
      coin's value from V, and repeat.
    * V = 41 | 0 coins used
    * V = 16 | 1 coin used (41 - 25 = 16)
    * V = 6  | 2 coins used (16 - 10 = 6)
    * V = 1  | 3 coins used (6 - 5 = 1)
    * V = 0  | 4 coins used (1 - 1 = 0)
    * Using this algorithm, we arrive at a total of 4 coins which is optimal

## Bitmasks
* Bitmasking is a technique used to perform operations at the bit level. Leveraging bitmasks often leads to faster runtime complexity and
  helps limit memory usage
* Test kth bit: `s & (1 << k);`
* Set kth bit: `s |= (1 << k);`
* Turn off kth bit: `s &= ~(1 << k);`
* Toggle kth bit: `s ^= (1 << k);`
* Multiple by 2<sup>n</sup>: `s << n;`
* Divide by 2<sup>n</sup>: `s >> n;`
* Intersection: `s & t;`
* Union: `s | t;`
* Set Subtraction: `s & ~t;`
* Extract lowest set bit: `s & (-s);`
* Extract lowest unset bit: `~s & (s + 1);`
* Swap Values:
             ```
                x ^= y;
                y ^= x;
                x ^= y;
             ```

## Runtime Analysis

#### Big O Notation
* *Big O Notation* is used to describe the upper bound of a particular algorithm. Big O is used to describe worst case scenarios

![Alt text](/Images/bigO.png?raw=true "Theta Notation")

#### Little O Notation
* *Little O Notation* is also used to describe an upper bound of a particular algorithm; however, Little O provides a bound
  that is not asymptotically tight

#### Big Ω Omega Notation
* *Big Omega Notation* is used to provide an asymptotic lower bound on a particular algorithm

![Alt text](/Images/bigOmega.png?raw=true "Theta Notation")

#### Little ω Omega Notation
* *Little Omega Notation* is used to provide a lower bound on a particular algorithm that is not asymptotically tight

#### Theta Θ Notation
* *Theta Notation* is used to provide a bound on a particular algorithm such that it can be "sandwiched" between
  two constants (one for an upper limit and one for a lower limit) for sufficiently large values

![Alt text](/Images/theta.png?raw=true "Theta Notation")

# Appendix C
## Game server features

The game server is a long-running program, and it also serves a number of non-timed, fixed-point network requests. So this type of service is characterized by special attention to stability and performance. If such procedures require multiple collaborations to improve the carrying capacity, they will also focus on the ease of deployment and expansion; at the same time, there is a need to consider how to achieve some degree of disaster recovery needs. As the multi-process work together, but also brought the complexity of development, which is the need to focus on the issue.

Functional constraints, is the decisive factor in architectural design. Based on the functional characteristics of the game business, the server-side system, the following special needs:

* Game and player data storage floor.
* Broadcast and synchronize player interaction data.
* Important logic to operate on the server, do a good job of verification, to prevent plug-in.

In response to the above demand characteristics, on the server side, we tend to focus on the use of computer memory and CPU, in order to specific business code, can try to meet the needs of high load low response delay. The most basic approach is "space for time", with a variety of ways to cache the CPU and memory space on the balance. There is also a constraint: bandwidth. Network bandwidth directly limits the processing power of the server, so the game server architecture must also consider this factor.

## Game server architecture features

For the game server architecture, the most important three parts is how to use the CPU, memory, network:
* Memory architecture: the main decision how to use the server memory to maximize the use of server-side memory to improve the load, reduce service latency.
* Logical architecture: Design how to use processes, threads, and joins for CPU scheduling. Select the synchronization, asynchronous and other different programming models to improve the stability of the server and load capacity. You can be partitioned sub-service, service world manner may be employed, the same function modules to a different server to process
* Communication mode: Decide which way to communicate. Based on the different types of games using different communication modes, such as http, tcp, udp and so on.

## Server evolution process

* 1, card and other casual games weak interactive game

  Server based on the different types of games, the architecture used is also different, we first talk about a simple model, using http communication mode architecture of the server:

  ![Alt text](/Images/card_server.png?raw=true "Cards Server")

  This server architecture and our common web server architecture is similar, but also the use of nginx load cluster support server level expansion, memcache do cache. The only different location is that the communication layer needs to re-process and encrypt the protocol. Generally, each company has its own set of http-based protocol-based frameworks, and rarely uses an open source framework.

* 2, long connected to the game server

  Long connection game and weak networking game is the place where the long connection, the player is state, the server can always interact with the client, the data transmission, unlike the weak network generally need to re-create a connection, the message Frequency and speed are faster than weak networking games. Long-linked online games architecture After several generations of iteration, the type has become increasingly rich, the following for each generation of server features and architectural model.

* 1) the first generation of online games server (single-threaded non-blocking)

  The earliest game server in 1978, the famous British financial school University of Essex student Roy Trubshaw prepared the world's first MUD program, called "MUD1".
  MUD1 is a plain text of the world, there is no picture, but different computer players can be in the game together adventure, exchange. Compared with the previous game with network connectivity, MUD1 is the first truly real-time multi-person interactive online games, its biggest feature is to ensure that the entire virtual world and the role of the continued development of the player - whether the player quit After the re-login or server restart, the game scene, chest, monster and puzzle remains the same, the player's role is still the last state.

  MUDOS uses a single-threaded, non-blocking socket to serve all players. All players' requests are sent to the same thread for processing. The main thread updates all objects every 1 second (network send and receive, object status, refresh map, refresh NPC ). Users use Telnet terminals such as Telnet to connect to MUDOS, use plain text for the game, each instruction is divided by carriage return. Such a system at the time each server carrying a 4000 at the same time the game. Since the release of MUDOS in 1991, all over the world have improved, expanded and introduced new versions for him.

  <!-- ![Alt text](/Images/MUD.png?raw=true "MUD") -->

  MUDOS game content through the LPC script to customize, logical processing using single-threaded tick polling, which is the first server-side architecture model, was later applied to different games. Follow-up a lot of games are the same as "UO", directly on the MUDOS secondary development, until now, some turn-based game, as well as the small amount of computing game, still use this server architecture.

  First Generation Server Architecture:

  ![Alt text](/Images/first_server.png?raw=true "First Server")

  Thread model
  ![Alt text](/Images/thread_md.png?raw=true "Thread MD")

* 2) The second generation of online games server (zoning)

  2000 or so, with the emergence of the graphical interface, the game more use of graphical interface and user interaction. At this point with the increase in the number of online games and game data increases, the server becomes non-burden. So there is a sub-service model. The decentralized model structure is as follows

  ![Alt text](/Images/part_server.png?raw=true "PART server")

  The sub-service model is the most typical of the game server, but also the longest model. In the early server load reached the upper limit, the game developers through the erection of more servers to solve. This provides a lot of games "parallel world", so that the game between the comparison, resulting in more space. Which is characterized by a game server is a separate world. Each server's account is independent, each server user status is not the same, a service is a world, we are not involved.

  Later, the game player called to fight across the service, so there was a cross-service war, coupled with the operation of the game, a single server game players less and less active, so there will be a late merger and migration, slowly The opening of the server, the merger formed a set of mature means of operation. At present, most games also use sub-service structure to set up the server, most of the page or use this model.

  *Thread scheduling*

  Although the sub-service can solve the bottleneck of server expansion, but a single server in the previous single-threaded way to run, no way to make full use of server resources, so the evolution of the following two kinds of thread model.

  Asynchronous - multi-threaded, based on each scene (or room), assign a thread. Each scene player belongs to a thread. The game scene is fixed, not a lot, so the number of threads can ensure that will not continue to increase. Each scene thread, the same tick ticking way to regularly update the scene (object status, refresh the map, refresh NPC) data status. If the player cross-scene, then use the delivery and notification of the way, inform the two scene threads, in order to update the two scenes of the player data.

  Multi-process. As a single process architecture, there will always be the limit of the load, the more complex the game, the lower the load of the single process, so be sure to break through the process of restrictions in order to support more complex games. Many other benefits of multi-process systems: the ability to take advantage of the multi-core CPU capacity, easier to disaster recovery.

  Multi-process system comparison of the classic model is the "three-tier architecture", for example, based on the previous scene thread to do improvements, the network part and the database part of a separate process to separate the logic process to concentrate on logical tasks, Network IO and disk IO, respectively, by the network process and DB process.

* 3)Third generation online game server

  Before the online games server are zoning, the players are divided on different servers, each server running the same logic, the player can not interact between different servers. Want more players in the same world, to maintain the player's activity, so there is a world service model. There are three types of evolution in the world:

  *Type One (three-tier architecture)*

  The gateway part is separated into a single-ended gate server, the DB part is separated into a DB server, the network function is extracted separately, allowing the user to unite to connect to a gateway server, and then the gateway server forwards the data to the back-end game server. And the data exchange between the game server is also unified to connect to the network management to exchange. All DB interactions are connected to the DB server for proxy processing.

  ![Alt text](/Images/type_one.png?raw=true "Type One")

  *Type Two（cluster)*

  With a type of experience, the follow-up is certainly the smaller the split, the better performance, similar to the current micro-service, each of the same module distributed to a server processing, multiple groups of servers together to form a game server. In general, we can simply group a group of servers into two categories: scene-related (eg, walking, fighting, etc.) and scenes that are not relevant (eg, guild chat, trade that is not restricted by the region, etc.). Often see a program is: gate server, scene server, non-scene server, chat manager, AI server and database proxy server. The following model:

  ![Alt text](/Images/type_two.png?raw=true "Type Two")

  Above we simply talk about the three types of common server features:

  Scene Server: It is responsible for the completion of the main game logic, including: the role of the game scene in the entry and exit, the role of walking and running, the role of fighting (including Daguai), the task of the claim. Scenario server design is the main performance of the game world server performance differences, its design is not only difficult to design the communication model, the more important is the entire server architecture and synchronization mechanism design.

  Non-scene server: it is mainly responsible for the game scene is not related to the completion of the game logic, these logic does not rely on the game's map system can also be normal, such as guild chat or world chat, the reason it is independent from the scene server, Save the scene server CPU and bandwidth resources, so that the scene server can handle those games as much as possible on the game fluency of the game logic.

  Gateway server: In a type of architecture, the player in a number of map jump or scene switching time to use the jump mode, in order to jump different servers. There is also a way to these nodes are through the gateway server management, player and gateway server interaction, each scene or server switch, there are unified gateway server to exchange data, so players will be more smooth operation.

  Through this type of server architecture, because the pressure dispersion, the performance will be significantly improved, the load is also greater, including the current large-scale MMORPG game is the use of this architecture. However, for each additional level of server, state machine complexity may be doubled, resulting in R & D and find the cost of bugs, the development team on the challenge is relatively large, no experience, it is wrong.

  *Three types (seamless map)*

  World of Warcraft in the seamless map, presumably we are impressed, the whole world's movement is not the same as in the past, when switching the scene when the need to wait for loading, but the direct walk in the past, experience smooth.

  Now the big map of the game using a seamless map is used in most of the 9-grid style to deal with, because the map is not so big World of Warcraft, so a single server can be used to process more, but similar to World of Warcraft this world map, Two questions must be considered:

  * 1、How to map a number of seamless nodes, especially when the map nodes are more time, how to ensure seamless splicing

  * 2、How to support the dynamic distribution, some areas of people, some areas less people, to ensure the maximum utilization of server resources

  In order to solve this problem, compared to the past in accordance with the map to cut the game, the seamless world does not exist a map of the above people and only by a server to deal with, then need a group of servers to deal with, each Node server To manage a map area, by the NodeMaster (NM) to provide them with overall management. Higher levels of World provide continental-level management services.

  ![Alt text](/Images/type_three.png?raw=true "Type Three")

  A node is responsible for the area, there is no need to connect together in geography, can be unified to a Node to manage, and these blocks are not geographically linked to the necessity. A Node in the end which management of the block, you can run the game according to the real-time load conditions, regular maintenance time to change the configuration above NodeMaster.

  Seamless migration of objects

  ![Alt text](/Images/node.png?raw=true "node")

  Players A, B, C, respectively, on behalf of three different states, as well as different modes of migration, we look at.

  Player A: Player A on node1 map server, controlled by node1, if you migrate to node2, you need to copy its data to node2 and remove it from node1.
  Player B: player B in node1 and node2 in the middle, at this time by node1 and node2 maintenance, if from node1 walk to node2 in the process, will request to 1, while the request to 2, all moved past and then removed.
  Player C: Player C on node2 map server, controlled by node2, if migrated to node1, it needs to copy its data to node1 and then remove from node2

  Specific World of Warcraft server analysis, too much space, we later talk.

* 3、Room server (game hall)

  Room play and MMORPG are very different, because of its online radio unit uncertainty and broadcast a small number. And need to match a room server for a few people into a server.

  This game is the most important of its "game hall" of the load, each "game room" by the logic limit, need to maintain and broadcast the player data is limited, but the "game hall" need to maintain a very high online The number of users, so in general, this game still need to do "sub-service". The typical game is the "hero alliance" of this type of game. The "game hall" inside the most challenging task is to "automatically match" the player into a "game room", which requires all online players to do search and filter.

  The player will log in to the "lobby server" and then select the function of the team game. The server will notify all the participating game clients, and the new one will be connected to the room server so that all the participating users will be able to interact with the game in the room server 

  ![Alt text](/Images/hall.png?raw=true "Hall")

## At last

  The game industry relative to the Internet application, its openness and standardization is not perfect, which led to other industries to see the game has a mystery, secret and closed.

  There are many reasons for this, the complexity of the game business and the small audience is the main reason, it is not like the web application of open source organizations and community gene support, there is no Internet industry such a large audience and influence, in addition to some More well-known game engine other than the function of the formation of each game company is based on their own business logic to build their own, each company's business direction has increased the flow of knowledge and the establishment of the standard, which the whole ecological development has been produced Constraints, especially those who want to join the game industry, the new, the access threshold is higher, online learning materials can be found very little.

  This phenomenon is currently changing, in addition to the audience is growing and rich, there are some technical organizations are promoting the progress of the entire community.

  Such as the annual unity of the General Assembly, as well as other excellent open source engines are actively promoting the creation of the entire game community, in addition to attract more outstanding technical talent and team to join, all this makes the game industry has become more open and standardized , So that the industry's knowledge can be circulation and inheritance. Of course, it is also expected that each player will be able to join in, share their own knowledge, and let the free and open shared spirit inherit every place.