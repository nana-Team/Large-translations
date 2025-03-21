#region textboxes

        public static Vector2 SmallEmpathisWave(int character) => new Vector2(0, -4f * MathHelper.Clamp(((float)Math.Sin(-Main.GlobalTimeWrappedHourly * 4f + character * 0.2f) - 0.7f) / 0.3f, 0f, 1f));


        #region Intro
        public static readonly TextboxInfo Intro_FirstTextbox = new(
           new(480f, SirNautilus.RegularSpeech, new TextSnippet(". . .", Color.White, 0.2f, 1.8f, null, TextSnippet.AppearFadingFromTop)), portraits["bored"]);

        public static readonly TextboxInfo Intro_SecondTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Mm?"),
                new TextSnippet(" ", characterDelay: 0.6f),
                new TextSnippet("Oh! Why, salutations! ", size: 1.1f, displacement: SmallEmpathisWave),
                new TextSnippet("What luck to find "),
                new TextSnippet("a surface-dweller", new Color(175, 220, 20), size: 1.1f),
                new TextSnippet(" in these treacherous depths...")
                ), portraits["pog"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Intro_ThirdTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Perchance, have you come across a "),
                new TextSnippet("battalion", SeaKingdomForcesColor),
                new TextSnippet(" of soldiers like myself? I have been separated from them for quite some time...")
                ), portraits["curious"]);
        public static readonly TextboxInfo Intro_FourthTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("... ", Color.White, 0.25f, 1.1f),
                new TextSnippet("You have not?"),
                new TextSnippet(" ", characterDelay: 0.4f),
                new TextSnippet("Hah!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Of course. I suppose waiting a bit longer wouldn't hurt anyone...", Color.White)
                ), portraits["surprised"]);
        public static readonly TextboxInfo Intro_FifthTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("After all, there is still time before ", Color.White),
                new TextSnippet("the enemy", UndeadForcesColor, 0.04f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" strikes back...", Color.White)
                ), portraits["suspicious"], CompleteIntroduction, false);
        #endregion

        #region main textboxes
        //Dialogue he uses only once, when finishing his intro speech
        public static readonly TextboxInfo Main_PostIntroTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Say, you seem vivacious and full of spirit. I have time to spare "),
                new TextSnippet("—", Color.White, characterDelay: 0.4f),
                new TextSnippet(" would you, perhaps, humor an old fish with ", Color.White),
                new TextSnippet("a friendly duel?", new Color(255, 209, 68), 0.025f, 1.1f, displacement: SmallEmpathisWave)
                ), portraits["neutral"]);

        //Dialogue he uses before the player defeats him for the first time
        public static readonly TextboxInfo[] Main_PreDefeatTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("...those ", Color.White, 0.03f, 0.6f, displacement: TextSnippet.SmallWaveDisplacement),
               new TextSnippet("maurauding devils", UndeadForcesColor, 0.03f, 0.65f, displacement: TextSnippet.SmallWaveDisplacement),
               new TextSnippet(" may soon return... I must prepare...", Color.White, 0.03f, 0.6f, displacement: TextSnippet.SmallWaveDisplacement)
                   ), portraits["suspicious"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("I cannot let my "),
                new TextSnippet("companions", SeaKingdomForcesColor),
                new TextSnippet(" down again..."),
                new TextSnippet(" I must become stronger.", Color.White, characterDelay: 0.05f, displacement: TextSnippet.SmallWaveDisplacement)
                ), portraits["angry"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("I appreciate that you have unsealed my tomb, but I shall not be going anywhere. I must stand guard in case "),
               new TextSnippet("they", UndeadForcesColor, displacement: SmallEmpathisWave),
               new TextSnippet(" come back to finish what they started.")
                ), portraits["suspicious"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("As part of the royal guards of the "),
                new TextSnippet("Sea Kingdom", SeaKingdomForcesColor),
                new TextSnippet(", my head would be quite the prize"),
                new TextSnippet("...!", Color.White, characterDelay: 0.2f),
                new TextSnippet(" Alas, taking my head would be no easy feat!")
                ), portraits["laughing"])
        };

        //Dialogue he uses after hes been defeated once
        public static readonly TextboxInfo[] Main_PostDefeatTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("I stopped keeping track of time long ago. Fate saw it fit that I would never leave, so I put my mind to training instead!", Color.White)), portraits["neutral"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("WOW!", Color.White, 0.04f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
               new TextSnippet(" That bout of ours scattered my bones all about the cavern... Thankfully, they never stay apart for long!", Color.White)
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Forgive me if I happen to repeat myself... Ghosts tend to fall into old habits.", Color.White)), portraits["suspicious"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Having experienced your fighting skills firsthand, I can tell you have a grand future ahead of you! "),
                new TextSnippet("If anyone asks, I was your instructor!", Color.White, 0.03f, 1.1f, displacement:SmallEmpathisWave))
                , portraits["starstruckhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Have I thanked you for shaking all the dust off my bones yet? I had not realized how much sand was clogging up my skull!", Color.White)
                ), portraits["curious"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Even if it does not match the feeling of water on my scales, "),
                new TextSnippet("the thrill of dueling makes me feel so alive!", displacement:TextSnippet.SmallWaveDisplacement)
                ), portraits["surprisedhands"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Signathion?", new Color(40, 220, 220), 0.03f, 1.1f),
                new TextSnippet(" He is my brave steed. ", Color.White),
                new TextSnippet("He has shown", Color.White, 0.025f, 0.9f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("…", Color.White, 0.4f, 0.9f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" far more loyalty than I. I am glad to have him with me.")
                ), portraits["curious"]),

            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("The grave on the surface said ", Color.White, 0.025f, 1.2f, displacement:TextSnippet.SmallRandomDisplacement),
                new TextSnippet("WHAT???", Color.White, 0.15f, 1.5f, displacement:TextSnippet.RandomDisplacement)
                ), portraits["shocked"], QuadrilateralBoxWithPortraitUI.ShakyPortrait)
        };

        //Dialogue he uses when its been a while since the player last interacted with them
        public static readonly TextboxInfo[] Main_FirstInteractionInAWhileTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Oh! ", Color.White, 0.05f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("We meet again, friend. I can sense that you have grown much stronger. The world must provide you plenty of opportunities for training...")
                ), portraits["surprisedhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("I see you are constantly finding better and stronger weapons! Unfortunately for me, I was only trained as a "),
                new TextSnippet("retiarius", new Color(175, 6, 22), 0.05f, 1.1f),
                new TextSnippet(", and alas, my net has rotted away!")
                ), portraits["neutral"]),
        };

        //Dialogue he uses after winning a duel
        public static readonly TextboxInfo[] Main_PlayerBeatenTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Your equipment may be lacking... Find yourself a more worthy weapon, and we can duel again.")
                ), portraits["neutral"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Ah, do not feel too bad about losing our duel. Improvement can only come after experiencing loss.")), portraits["neutral"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Do not feel down, everyone has their losses! Losing to "),
                new TextSnippet("Signathion", new Color(40, 220, 220), 0.04f, 1.1f),
                new TextSnippet(" and me is nothing to be ashamed of! After all, we work in perfect tandem. ")
                ), portraits["laughing"])
        };

        //Dialogue he uses when talked to right after defeating him
        public static readonly TextboxInfo[] Main_NautilusJustBeatenTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Ready for a rematch?", new Color(255, 209, 68), 0.025f, 1.1f, displacement:TextSnippet.SmallWaveDisplacement),
                new TextSnippet(" I'll be sure to kick "),
                new TextSnippet("your", displacement:TextSnippet.RandomDisplacement),
                 new TextSnippet(" bucket this time!")
                ), portraits["angryhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("It's been forever since I've had a fight "),
                new TextSnippet("THIS", Color.White, 0.025f, 1.2f, displacement:TextSnippet.WaveDisplacement),
                new TextSnippet(" exhilarating! Say, would you like to spar once more?", Color.White)
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Already back for more? Fighters as devoted as you are a rarity, my friend!")
                ), portraits["surprisedhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Ha! Fighting you has been a thrill, this feeling"),
                new TextSnippet("...", Color.White, characterDelay: 0.2f),
                new TextSnippet(" once I had fled, I had thought I would never be blessed by it again!")
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
        };

        //Dialogue he uses when talked right after nohitting him
        public static readonly TextboxInfo[] Main_NautilusNohittedTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("You managed to dodge all of my attacks?!?", Color.White, 0.04f, 1.5f, displacement: TextSnippet.RandomDisplacement),
                new TextSnippet(" You could have made a living off the fame and riches from participating in the ", Color.White),
                new TextSnippet("blood sports", new Color(175, 6, 22)),
                new TextSnippet(" of the colosseum, back in the days...", Color.White)
                ), portraits["starstruckhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("...I couldn't even manage to land a single hit on you... Practice truly does make perfect!")
                ), portraits["surprisedhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait)
        };

        public static readonly TextboxInfo Main_RareNautilusNohitTextbox = new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Terraria - Nautilus No Damage", Color.White, 0.05f, 2.5f, apparition: TextSnippet.AppearFadingFromTop))
                , portraits["starstruckhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        //Dialogue he uses right after beating him in less than 20 seconds
        public static readonly TextboxInfo[] Main_NautilusOutmatchedTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Your weaponry is giving you an unfair advantage!! How is one supposed to train under these circumstances?!?", Color.White, displacement: TextSnippet.SmallRandomDisplacement)), portraits["unamused"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Pah!", Color.White, 0.05f, 1.1f, displacement: TextSnippet.RandomDisplacement),
                new TextSnippet(" I hope you do not feel satisfaction from your victory, it was hardly earned ", Color.White),
                new TextSnippet(" ...No hard feelings, though.", Color.White, 0.04f, 0.6f)
                ), portraits["nerd"], QuadrilateralBoxWithPortraitUI.ShakyPortrait)
        };


        //One-time dialogue that appears after defeating Desert Scourge
        public static readonly TextboxInfo Progression_DesertScourgeDefeated = new(
            new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("Ah!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Have you slain the source of those "),
                new TextSnippet("dreadful rumbles", Color.White, 0.025f, 1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("? "),
                new TextSnippet("These bones of mine aren’t fit for a meal, but it would be quite the conundrum if this cavern collapsed, so you have my thanks!")
                ), portraits["neutral"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        //One-time dialogue that appears after entering Hardmode
        public static readonly TextboxInfo Progression_HardmodeReached = new(
            new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("My connection to the afterlife is rather tenuous, but even I can tell the spirits have become quite rambunctious as of late."),
                new TextSnippet(" If I were to guess, you probably have some part in that affair.", Color.White, 0.025f, 0.8f)
                ), portraits["curious"]);

        public static readonly TextboxInfo[] ProgressionReportTextboxes = new TextboxInfo[] { Progression_DesertScourgeDefeated, Progression_HardmodeReached };

        //One-time dialogue that appears when wearing Nautilus boss mask, Sea Rider Tunic and Sea Rider Greaves
        public static readonly TextboxInfo EasterEgg_Doppelganger = new(
            new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("Hmph!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Well, well, well, I hardly recognized you, wearing my armor.", Color.White),
                new TextSnippet(" And... say, what a peculiar helmet; those chiseled features", Color.White),
                new TextSnippet("... ", Color.White, 0.15f, 1f),
                new TextSnippet("Ah!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Never mind me, such odd thoughts cross my mind at times.")
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);
        #endregion

        #region lore textboxes

        #region Pre defeat
        public static readonly TextboxInfo Lore_FirstWhoAreYou = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("I am ", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("Sir Nautilus", SeaKingdomForcesColor, 0.025f, 1.2f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet(", a ", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("Knight of the Sea", SeaKingdomForcesColor, 0.03f, 1.2f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet(" serving under ", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("King Amidias", SeaKingdomForcesColor, 0.025f, 1.2f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet(", ruler of the great ", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("Sea Kingdom", SeaKingdomForcesColor, 0.025f, 1.2f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement)
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_SecondWhoAreYou = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("It is unfamiliar to you? My, you must have traveled from quite far away!")
                ), portraits["curious"], ExitWhoAreYou);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_WhatAreYouDoing = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...I am on leave to train, as I must be prepared for the encroaching threat. Those "),
                new TextSnippet("murderers", UndeadForcesColor, characterDelay: 0.06f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" will certainly return"),
                new TextSnippet("...", Color.White, characterDelay: 0.4f),
                new TextSnippet(" yes, those  ", Color.White, characterDelay: 0.04f),
                new TextSnippet("vile bastards", UndeadForcesColor, characterDelay: 0.05f),
                new TextSnippet("... they will return, and this time... Well, I have steeled myself.", Color.White, characterDelay: 0.04f)
                ), portraits["unamused"], ExitWhatAreYouDoing);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_WhyHere = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("I", Color.White),
                new TextSnippet("—", Color.White, characterDelay: 0.5f),
                new TextSnippet("er, well. This solitude allows me to focus, you see. I must train not only my body, but also my mind! "),
                new TextSnippet("To... ", Color.White, characterDelay: 0.1f),
                new TextSnippet("To look within myself, and see where I am"),
                new TextSnippet("...", Color.White, characterDelay: 0.15f),
                new TextSnippet(" weak.")
                ), portraits["suspicious"], ExitWhyHere, false);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstWhatNowPreDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...", Color.White, 0.04f, 3f, apparition: TextSnippet.AppearFadingFromTop)
                ), portraits["shocked"]);

        public static readonly TextboxInfo Lore_SecondWhatNowPreDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...Hmph! You are quite the nosy fellow. Haha, well, perhaps I have grown too accustomed to ", Color.White),
                new TextSnippet("Signathion", new Color(12, 241, 176), 0.05f, 1.1f),
                new TextSnippet("’s quiet company.", Color.White)
                ), portraits["neutral"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_ThirdWhatNowPreDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("I will impart more information if you can "),
                new TextSnippet("defeat me in a duel! ", new Color(255, 209, 68)),
                new TextSnippet("—", Color.White, characterDelay: 0.5f),
                new TextSnippet(" Prove to me with your strength, your integrity, that you are the right one to pass on my tale!")
                ), portraits["suspicious"], ExitWhatNowPreDefeat, false);
        #endregion

        #region Post-defeat
        public static readonly TextboxInfo Lore_FirstWhatReallyHappened = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet(" ", Color.White, characterDelay: 2f),
                new TextSnippet("...", Color.White, 0.2f, 1.3f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("I know that the ", Color.White, 0.1f, 1.3f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("Kingdom", SeaKingdomForcesColor, 0.1f, 1.3f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" has fallen. ", Color.White, 0.1f, 1.3f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("...I never saw the outcome of the battle myself, but even as I fled, my skin blistered in the boiling water.", Color.White, characterDelay: 0.04f)
                ), portraits["hollow"]);

        public static readonly TextboxInfo Lore_SecondWhatReallyHappened = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("And the ", Color.White, characterDelay: 0.05f),
                new TextSnippet("invaders", UndeadForcesColor, 0.1f, 1.1f),
                new TextSnippet("...!! ", Color.White, characterDelay: 0.05f),
                new TextSnippet("They were not of flesh and blood!! They were our own, our fallen!", Color.White),
                new TextSnippet(" Not only soldiers, but all of our dead!", Color.White),
                new TextSnippet(" Family, friends, children... my...", Color.White, characterDelay: 0.05f, displacement: TextSnippet.SmallRandomDisplacement)
                ), portraits["enraged"]);

        public static readonly TextboxInfo Lore_ThirdWhatReallyHappened = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...", Color.White, 1.2f, 1.6f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Oh... ", Color.White, characterDelay: 0.04f),
                new TextSnippet("King Amidias ", SeaKingdomForcesColor, 0.04f, 1.1f),
                new TextSnippet("...", Color.White, characterDelay: 0.6f)
                ), portraits["hollow"]);

        public static readonly TextboxInfo Lore_FourthWhatReallyHappened = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet(" If only I had remained loyal to the end!! My very bones still ache with regret!! ", Color.White),
                new TextSnippet("It is what ties me to this wretched cavern!!", Color.White, displacement: TextSnippet.SmallRandomDisplacement)
                ), portraits["enraged"], ExitWhatReallyHappened);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstWhatHappenedToYou = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("When I fled, I escaped to these caverns, still beneath the ocean at the time. Those... ", Color.White, characterDelay: 0.04f),
                new TextSnippet("undead", UndeadForcesColor, 0.1f, 1.1f),
                 new TextSnippet(", were wreathed in hellfire that blazed even underwater. I imagine that they burned until the water evaporated.", Color.White, characterDelay: 0.04f)
                ), portraits["hollow"]);

        public static readonly TextboxInfo Lore_SecondWhatHappenedToYou = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Our kind can manage without water for a short period, but the destruction also trapped me here, and soon, I dried out.")
                ), portraits["neutral"], ExitWhatHappenedToYou);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstHowDidYouKeepYourSanity = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("I cannot say that I did not go mad. ", Color.White, characterDelay: 0.06f),
                new TextSnippet("There have been times I dreamt, reliving memories of that battle. Those who fell protecting our people, bursting into flame to join the ", Color.White, characterDelay: 0.04f),
                new TextSnippet("ranks of the undead", UndeadForcesColor, characterDelay: 0.04f),
                 new TextSnippet("...", Color.White, characterDelay: 0.04f)
                ), portraits["solemn"]);

        
        public static readonly TextboxInfo Lore_SecondHowDidYouKeepYourSanity = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("I—I could not tell on which side I fought in those nightmares. ", Color.White, characterDelay: 0.04f),
                new TextSnippet("But for better or worse, when I wake up in this cavern... I remember that I had fled, and died here instead.", Color.White, characterDelay: 0.04f)
                ), portraits["solemn"], ExitHowDidYouKeepYourSanity, false);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("I am rather uncertain"),
                new TextSnippet("...", Color.White, characterDelay: 0.15f),
                new TextSnippet(" but I shall remain here"),
                new TextSnippet("...", Color.White, characterDelay: 0.15f),
                new TextSnippet(" not that I have much choice in the matter.")
                ), portraits["neutral"]);

        public static readonly TextboxInfo Lore_SecondWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("The song of the ocean’s currents has long since been replaced by the chitter of insects, and there is nothing that can bring it back"),
                new TextSnippet("...", Color.White, characterDelay: 0.4f),
                new TextSnippet(" the times have changed and I am a relic of the past.", Color.White, characterDelay: 0.025f, displacement: TextSnippet.SmallRandomDisplacement)
                ), portraits["suspicious"]);

        public static readonly TextboxInfo Lore_ThirdWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...", Color.White, 0.4f, 3f, apparition: TextSnippet.AppearFadingFromTop)
                ), portraits["curious"]);

        public static readonly TextboxInfo Lore_FourthWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Pardon me for getting so gloomy! I would not be able to bear the thought of driving you away because of my sob story.")
                ), portraits["pog"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_FifthWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("You", new Color(175, 220, 20), 0.06f, 1.5f, displacement: TextSnippet.RandomDisplacement),
                new TextSnippet("! For me, continue onwards!", Color.White, 0.06f, 1.5f, displacement: TextSnippet.RandomDisplacement)
                ), portraits["starstruckhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_SixthWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("I feel great solace in knowing that you will continue to grow and change.")
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_SeventhWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("See what there is to see, and forget this old fish’s sorrows, as I have!")
                ), portraits["laughing"], GiveKeepsakeToPlayer, false);

        public static readonly TextboxInfo Lore_EighthWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Anyhow, please take this "),
                new TextSnippet("royal medallion", SeaKingdomForcesColor),
                new TextSnippet(" as a token of our bond! It’s not much, but I hope it reminds you to pay me a visit from time to time!")
                ), portraits["surprised"], ExitWhatNowPostDefeat, false);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstWhatsUp = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Well, apart from your visits, it unfortunately remains quite uneventful here.")
                ), portraits["neutral"]);

        public static readonly TextboxInfo Lore_SecondWhatsUp = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Hmmm", Color.White),
                new TextSnippet("...", Color.White, characterDelay: 0.2f),
                new TextSnippet(" say, have you met any of my kin? I am quite eager to know if any of them remain...")
                ), portraits["curious"]);
        #endregion

        #endregion

        #region Other textboxes
        public static readonly TextboxInfo FightStart_JustificationOnFirstInteraction = new(
            new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("Ah!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" These old bones have not seen battle in a long time, but I have still been training rigorously!", Color.White),
                new TextSnippet(" ", Color.White, 0.6f),
                new TextSnippet("En garde!", new Color(255, 209, 68), 0.04f, 1.3f, null, TextSnippet.AppearFadingFromTop, TextSnippet.RandomDisplacement)
                ), portraits["laughing"], SummonNautilus, true, QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo UncannyTextbox = new(
           new(480f, SirNautilus.RegularSpeech,
               new TextSnippet("...", Color.White, 0.2f, 1.8f, null, TextSnippet.AppearFadingFromTop),
               new TextSnippet(" wait", Color.White, 0.03f, 0.9f, null, TextSnippet.AppearFadingFromTop, TextSnippet.SmallRandomDisplacement),
               new TextSnippet(" ", Color.White, 0.36f, 1f, null),
               new TextSnippet("it was ", Color.White, 0.03f, 1f, null, TextSnippet.AppearFadingFromTop, TextSnippet.SmallRandomDisplacement),
               new TextSnippet("HOW MANY DEVS???", Color.White, 0.08f, 2f, null, TextSnippet.AppearFadingFromTop, TextSnippet.SmallRandomDisplacement)
               ), portraits["uncanny"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        #endregion

        #endregion
        
        #region Buttons
        public static readonly ButtonInfo StartFightButton = new(new TextSnippet("Challenge", Color.White, displacement: TextSnippet.RandomDisplacement), InitiateFight, false);
        public static readonly ButtonInfo LoreButton = new(new TextSnippet("Who're you?", Color.White), OpenLoreQuestions, false);

        public static readonly ButtonInfo GoToWhyHereButton = new(new TextSnippet("Why here?", Color.White), AskWhyHere, false);
        public static readonly ButtonInfo GoToWhatAreYouDoingButton = new(new TextSnippet("What are you doing?", Color.White), AskWhatAreYouDoing, false);

        public static readonly ButtonInfo GoToWhatNowFromWhyHereButton = new(new TextSnippet("What now?", Color.White), AskWhatNowFromWhyHere, false);
        public static readonly ButtonInfo GoToWhatNowFromWhatchaDoinButton = new(new TextSnippet("What now?", Color.White), AskWhatNowFromWhatAreYouDoing, false);

        public static readonly ButtonInfo GoToWhatHappenedToYouButton = new(new TextSnippet("What happened to you?", Color.White), AskWhatHappenedToYou, false);
        public static readonly ButtonInfo GoToHowDidYouKeepYourSanityButton = new(new TextSnippet("How'd you stay sane??", Color.White), AskHowDidYouKeepYourSanity, false);

        public static readonly ButtonInfo GoToWhatNowFromWhatHappenedToYouButton = new(new TextSnippet("What now?", Color.White), AskWhatNowFromWhatHappenedToYou, false);
        public static readonly ButtonInfo GoToWhatNowFromHowDidYouKeepYourSanityButton = new(new TextSnippet("What now?", Color.White), AskWhatNowFromHowDidYouKeepYourSanity, false);

        public static readonly ButtonInfo GoToWhatsUpFromWhatHappenedToYouButton = new(new TextSnippet("What's up?", Color.White), AskWhatsUpFromWhatHappenedToYou, false);
        public static readonly ButtonInfo GoToWhatsUpFromHowDidYouKeepYourSanityButton = new(new TextSnippet("What's up?", Color.White), AskWhatsUpFromHowDidYouKeepYourSanity, false);
        #endregion
