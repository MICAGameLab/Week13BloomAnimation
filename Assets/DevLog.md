24_0407 Preparing for class week 13
Goal:  A package the demos Animation using animator, Post Processing, grabbing ands releasing objects...

Plan for work session Tasks  1] - 4]

1] Set up an animated sprite with idle, running, a third state

states:  
1. Moving left and Moving right (same state Animator Controller)
2. Idle
3. Waving (set hand sprite (sprite or GO?) active with animation)

--Get the states made in the animator
--make trasitions between then with bools
--make the animcontroller work with the boolks as I expect, just clicking the bool conditions on and off in unity
--Make the clips for each state
--add the code to run the animator--


2] set up sprite sheet with transform.position moving due to physics on arrow keys
3] Start the Walk animation loop when Arrow key pressed...  but only start it once, not strart every frame that the arrow key is pressed: Using animation Transitions solves this problem!
4] Do some post processing  Maybe just a vignette that gets smaller as player moves....


Notes: 
3. Waving SpriteRenderer.enable property of animator can make hand sprite apear for the waving animation and sprite turns off when waving animation is done
1. Moving I will use the animator to move Triangle on the X axis.  I will use animation clip to move Triangle on the Y axis to bobble up and down while Moving


Plan for work session 24_0408
1. Waving state: Make it work with same Animator as Moving and idle

2. Explain "How to Animate" 
    a.  decide what states you want to animate
    b.  decide how states shouold be activated, like by player of by something in game
    c.  Create states in Controller with playholder clips
    d.  Create the trasitions and the Conditions for them according to my plan
    e.  Get the Controller running as I wanyt in Unity
    d. Get the conditions changong in code according to my plan.  Do them one by one (writing them doen here helps me decide how to do them)
        --idle --> MovingLeft    LeftArrowKey
        --idle --> moviingRight  RightArrowKey
        --movingLeft --> MovingRight (flipX in code)
        --Moving --> Waving  
            --?? Can I make the Hand appear and wave while moving and while ideling?  Do I need a separate Controllor?
            --?? What is Blendtree for? 
        --Moving -->idle        ArrowKey up
            --?? Do I need to capture ArrowKey up?
            --Use the Animatoin Controller to see how transitions work and then I need to code that transition so I will find out

3. Do Bloom Post Processing
    a. Want to explain how to set up our version of Unity urp 2D 2022.3 for doing post processing
    b. Learning How to do Bloom: 
         Add a light
         Set its intensity to >1
         Tell camera to do post processing
         ?? Make Post Processing layers?  

         -- Finding tutorial for Bloom:  Find tutorial that is using 2022 Unity 2D
                -- Note that Google search AI linked me to Unity 5.4 Manual.  :D
                -- Search for "Bloom: in current Unity manual actually helpful.  Changes in Unity 2202.2 is a search result!  Updates in Unity are in the Manual
                -- "Post Processing and Full-screen effects" is what Unity manual calls Bloom and post procesing
https://docs.unity3d.com/Manual/30_search.html?q=bloom
https://docs.unity3d.com/Manual/PostProcessingOverview.html
                -- Unity Manual has a chart for each post processing efect and how to do it for each type of rendering pipeline. 
https://docs.unity3d.com/Packages/com.unity-render-pipelines.universal@17.0/manual/post-processing-bloom.html 
                -- Says Bloom uses Volume.....  
               
"Using Bloom
Bloom uses the Volume system, so to enable and modify Bloom properties, you must add a Bloom override to a Volume in your scene.

To add Bloom to a Volume:

In the Scene or Hierarchy view, select a GameObject that contains a Volume component to view it in the Inspector.
In the Inspector, navigate to Add Override > Post-processing, and click on Bloom. Universal Render Pipeline applies Bloom to any Camera this Volume affects."

                -- ?? is there such a thing as 2D Volume?? YES There is a Box Volume!  This page on Volume is helpful
https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@17.0/manual/Volumes.html

4. ?? What specific Post Processing for Mobile?
5. ?? What specific Post Processing for WebGL?
        -- Default Volumes seem like the answer?
_"Default volumes
All URP scenes have two default global volumes:

The Default Volume for your whole project, which uses the Volume Profile set in Project Settings > Graphics > URP > Default Volume Profile.
The global volume for the active quality level, which uses the Volume Profile set in the active URP Asset > Volumes > Volume Profile.
URP evaluates the default volumes only when you first load a scene or when you change the quality level, instead of every frame. If you use only the default volumes in a scene, URP has less work to do at runtime.

URP sets the default volumes to the lowest priority, so any volume you add to a scene overrides them.

Refer to the following for more information:

Configure the Default Volume
Configure the global volume for a quality level"



Explain How to Learn While doing  
        Directed reading
        Know what question you are asking at the moment
        Leave time between work sessions for learing to take effect in your head before 
Explain working in steps, and writing these steps down in DevLog
     Use Devlog to reduce coignitive load


7:15 am Plan tasks in prioroty

1. Learn Bloom and Get Bloom Working so I can explain it
2. Get Animation working 
3. Prepare for Class

7:25 done making notes and making this priority list! 

7:37 actually starting


