#region textboxes

        public static Vector2 SmallEmpathisWave(int character) => new Vector2(0, -4f * MathHelper.Clamp(((float)Math.Sin(-Main.GlobalTimeWrappedHourly * 4f + character * 0.2f) - 0.7f) / 0.3f, 0f, 1f));


        #region Intro
        public static readonly TextboxInfo Intro_FirstTextbox = new(
           new(480f, SirNautilus.RegularSpeech, new TextSnippet(". . .", Color.White, 0.2f, 1.8f, null, TextSnippet.AppearFadingFromTop)), portraits["bored"]);

        public static readonly TextboxInfo Intro_SecondTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Хм?"),
                new TextSnippet(" ", characterDelay: 0.6f),
                new TextSnippet("О-о! Какая встреча! ", size: 1.1f, displacement: SmallEmpathisWave),
                new TextSnippet("Не ожидал встретить "),
                new TextSnippet("сухопутника", new Color(175, 220, 20), size: 1.1f),
                new TextSnippet(" в этих коварных пучинах...")
                ), portraits["pog"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Intro_ThirdTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Скажи, не встречал ли ты "),
                new TextSnippet("товарищей по оружию", SeaKingdomForcesColor),
                new TextSnippet(" вроде меня? Я отбился от своего отряда... и с тех пор прошло немало.")
                ), portraits["curious"]);
        public static readonly TextboxInfo Intro_FourthTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("... ", Color.White, 0.25f, 1.1f),
                new TextSnippet("Неужто нет?"),
                new TextSnippet(" ", characterDelay: 0.4f),
                new TextSnippet("Ха!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Ну что же, подожду ещё. Время терпит...", Color.White)
                ), portraits["surprised"]);
        public static readonly TextboxInfo Intro_FifthTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("К конце концов, до атаки ", Color.White),
                new TextSnippet("врага", UndeadForcesColor, 0.04f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" ещё есть время...", Color.White)
                ), portraits["suspicious"], CompleteIntroduction, false);
        #endregion

        #region main textboxes
        //Dialogue he uses only once, when finishing his intro speech
        public static readonly TextboxInfo Main_PostIntroTextbox = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("А ты полон огня, дружище. Пока время позволяет "),
                new TextSnippet("—", Color.White, characterDelay: 0.4f),
                new TextSnippet(" не хочешь ли скрасить досуг старой рыбины ", Color.White),
                new TextSnippet("дружеской дуэлью?", new Color(255, 209, 68), 0.025f, 1.1f, displacement: SmallEmpathisWave)
                ), portraits["neutral"]);

        //Dialogue he uses before the player defeats him for the first time
        public static readonly TextboxInfo[] Main_PreDefeatTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("...Эти ", Color.White, 0.03f, 0.6f, displacement: TextSnippet.SmallWaveDisplacement),
               new TextSnippet("проклятые твари", UndeadForcesColor, 0.03f, 0.65f, displacement: TextSnippet.SmallWaveDisplacement),
               new TextSnippet(" могут вернуться... Я должен быть готов...", Color.White, 0.03f, 0.6f, displacement: TextSnippet.SmallWaveDisplacement)
                   ), portraits["suspicious"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Не могу подвести "),
                new TextSnippet("соратников", SeaKingdomForcesColor),
                new TextSnippet(" вновь..."),
                new TextSnippet(" Я обязан стать сильнее.", Color.White, characterDelay: 0.05f, displacement: TextSnippet.SmallWaveDisplacement)
                ), portraits["angry"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Благодарен за то, что вскрыл мою гробницу... но я не уйду. Должен стоять на страже, пока "),
               new TextSnippet("они", UndeadForcesColor, displacement: SmallEmpathisWave),
               new TextSnippet(" не вернулись закончить то, что начали.")
                ), portraits["suspicious"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Как страж "),
                new TextSnippet("Морского королевства", SeaKingdomForcesColor),
                new TextSnippet(", моя голова — желанный трофей..."),
                new TextSnippet("...!", Color.White, characterDelay: 0.2f),
                new TextSnippet(" Хотя заполучить её будет подвигом немалым!")
                ), portraits["laughing"])
        };

        //Dialogue he uses after hes been defeated once
        public static readonly TextboxInfo[] Main_PostDefeatTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Я давно перестал считать дни. Раз судьба заперла меня здесь — я посвятил себя тренировкам!", Color.White)), portraits["neutral"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("ВАУ!", Color.White, 0.04f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
               new TextSnippet(" Наш поединок разбросал мои кости по всей пещере... К счастью, они всегда возвращаются!", Color.White)
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Прости, если повторяюсь... Призраки - создания привычки.", Color.White)), portraits["suspicious"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Повидав твоё мастерство, уверен — тебя ждёт великая слава! "),
                new TextSnippet("Если спросят, говори, что учился у меня!", Color.White, 0.03f, 1.1f, displacement:SmallEmpathisWave))
                , portraits["starstruckhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("А я уже благодарил за то, что ты стряхнул пыль с моих костей? В черепе песка было на год вперёд!", Color.White)
                ), portraits["curious"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Хоть и не сравнить с ощущением морской прохлады на чешуе... "),
                new TextSnippet("но в бою я чувствую себя живым!", displacement:TextSnippet.SmallWaveDisplacement)
                ), portraits["surprisedhands"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Сигнатий?", new Color(40, 220, 220), 0.03f, 1.1f),
                new TextSnippet(" Мой верный скакун. ", Color.White),
                new TextSnippet("Он", Color.White, 0.025f, 0.9f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("...", Color.White, 0.4f, 0.9f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" проявил куда больше верности, чем я. Рад, что он со мной.")
                ), portraits["curious"]),

            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("Надпись на могиле гласила: ", Color.White, 0.025f, 1.2f, displacement:TextSnippet.SmallRandomDisplacement),
                new TextSnippet("ЧТООО?", Color.White, 0.15f, 1.5f, displacement:TextSnippet.RandomDisplacement)
                ), portraits["shocked"], QuadrilateralBoxWithPortraitUI.ShakyPortrait)
        };

        //Dialogue he uses when its been a while since the player last interacted with them
        public static readonly TextboxInfo[] Main_FirstInteractionInAWhileTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("О! ", Color.White, 0.05f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("Снова ты! Чувствую, стал сильнее. Мир щедр на испытания...")
                ), portraits["surprisedhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Вижу, обзавёлся новым оружием! Увы, я обучен лишь "),
                new TextSnippet("ретиарию", new Color(175, 6, 22), 0.05f, 1.1f),
                new TextSnippet(", а моя сеть истлела.")
                ), portraits["neutral"]),
        };

        //Dialogue he uses after winning a duel
        public static readonly TextboxInfo[] Main_PlayerBeatenTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Снаряжение подкачало... Найди достойный клинок — и повторим.")
                ), portraits["neutral"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Ах, не кори себя за поражение. Поражение — ступень к росту.")), portraits["neutral"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Не печалься, не каждая битва оканчивается победой. А проиграть "),
                new TextSnippet("Сигнатию", new Color(40, 220, 220), 0.04f, 1.1f),
                new TextSnippet(" и мне вовсе не стыдно! Мы — идеальный тандем. ")
                ), portraits["laughing"])
        };

        //Dialogue he uses when talked to right after defeating him
        public static readonly TextboxInfo[] Main_NautilusJustBeatenTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Реванш?", new Color(255, 209, 68), 0.025f, 1.1f, displacement:TextSnippet.SmallWaveDisplacement),
                new TextSnippet(" На сей раз я "),
                new TextSnippet("выбью", displacement:TextSnippet.RandomDisplacement),
                 new TextSnippet(" из тебя дух!")
                ), portraits["angryhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Столько лет не дрался "),
                new TextSnippet("НАСТОЛЬКО", Color.White, 0.025f, 1.2f, displacement:TextSnippet.WaveDisplacement),
                new TextSnippet(" зажигательно! Ещё разок?", Color.White)
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Уже вернулся? Столь азартные до битв редко встречаются!")
                ), portraits["surprisedhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Ха! Этот азарт"),
                new TextSnippet("...", Color.White, characterDelay: 0.2f),
                new TextSnippet(" думал, уже не испытаю его!")
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
        };

        //Dialogue he uses when talked right after nohitting him
        public static readonly TextboxInfo[] Main_NautilusNohittedTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Ты уклонился от всех ударов?!", Color.White, 0.04f, 1.5f, displacement: TextSnippet.RandomDisplacement),
                new TextSnippet(" В былые времена тебя бы носили на руках в ", Color.White),
                new TextSnippet("кровавых играх", new Color(175, 6, 22)),
                new TextSnippet(" колизея...", Color.White)
                ), portraits["starstruckhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("...Не смог задеть тебя ни разу... Видимо, практика решает всё!")
                ), portraits["surprisedhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait)
        };

        public static readonly TextboxInfo Main_RareNautilusNohitTextbox = new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Terraria — Наутилус без урона", Color.White, 0.05f, 2.5f, apparition: TextSnippet.AppearFadingFromTop))
                , portraits["starstruckhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        //Dialogue he uses right after beating him in less than 20 seconds
        public static readonly TextboxInfo[] Main_NautilusOutmatchedTextboxes = new TextboxInfo[]
        {
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Твоё оружие слишком мощно! Как вообще тренироваться в таких условиях?!", Color.White, displacement: TextSnippet.SmallRandomDisplacement)), portraits["unamused"]),
            //------------------------------------------------------------------
            new(new(480f, SirNautilus.RegularSpeech, new TextSnippet("Пф!", Color.White, 0.05f, 1.1f, displacement: TextSnippet.RandomDisplacement),
                new TextSnippet(" Надеюсь, не гордишься победой, что далась слишком легко. ", Color.White),
                new TextSnippet(" ...Но без обид", Color.White, 0.04f, 0.6f)
                ), portraits["nerd"], QuadrilateralBoxWithPortraitUI.ShakyPortrait)
        };


        //One-time dialogue that appears after defeating Desert Scourge
        public static readonly TextboxInfo Progression_DesertScourgeDefeated = new(
            new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("А!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Это ты усмирил "),
                new TextSnippet("подземный гул", Color.White, 0.025f, 1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("? "),
                new TextSnippet("Мои кости — не лучший обед, но обвал пещеры был бы проблемой... Спасибо!")
                ), portraits["neutral"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        //One-time dialogue that appears after entering Hardmode
        public static readonly TextboxInfo Progression_HardmodeReached = new(
            new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("Связь с загробным миром слаба, но даже так чувствую — духов будто с цепи слетели."),
                new TextSnippet(" Думается мне, тут замешан ты.", Color.White, 0.025f, 0.8f)
                ), portraits["curious"]);

        public static readonly TextboxInfo[] ProgressionReportTextboxes = new TextboxInfo[] { Progression_DesertScourgeDefeated, Progression_HardmodeReached };

        //One-time dialogue that appears when wearing Nautilus boss mask, Sea Rider Tunic and Sea Rider Greaves
        public static readonly TextboxInfo EasterEgg_Doppelganger = new(
            new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("Хм!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Ну и ну, едва узнал тебя в моих доспехах.", Color.White),
                new TextSnippet(" Шлем любопытный... и эти детали", Color.White),
                new TextSnippet("... ", Color.White, 0.15f, 1f),
                new TextSnippet("А!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Неважно! Дурацкие мысли иногда лезут.")
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);
        #endregion

        #region lore textboxes

        #region Pre defeat
        public static readonly TextboxInfo Lore_FirstWhoAreYou = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Я - ", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("Господин Наутилус", SeaKingdomForcesColor, 0.025f, 1.2f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet(", ", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("Рыцарь Морей", SeaKingdomForcesColor, 0.03f, 1.2f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet(" служивший при дворе ", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("Короля Амидиаса", SeaKingdomForcesColor, 0.025f, 1.2f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet(", владыки великого ", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("Морского королевства", SeaKingdomForcesColor, 0.025f, 1.2f, displacement: TextSnippet.SmallWaveDisplacement),
                new TextSnippet("!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallWaveDisplacement)
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_SecondWhoAreYou = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Не слышал о нём? Должно быть, ты из далёких краёв!")
                ), portraits["curious"], ExitWhoAreYou);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_WhatAreYouDoing = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...Я готовлюсь к угрозе. Эти "),
                new TextSnippet("убийцы", UndeadForcesColor, characterDelay: 0.06f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" обязательно вернутся"),
                new TextSnippet("...", Color.White, characterDelay: 0.4f),
                new TextSnippet(" да, эти  ", Color.White, characterDelay: 0.04f),
                new TextSnippet("мерзкие твари", UndeadForcesColor, characterDelay: 0.05f),
                new TextSnippet("... они вернутся... и на сей раз я буду готов.", Color.White, characterDelay: 0.04f)
                ), portraits["unamused"], ExitWhatAreYouDoing);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_WhyHere = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Я", Color.White),
                new TextSnippet("-", Color.White, characterDelay: 0.5f),
                new TextSnippet("э-э... уединение помогает сосредоточиться. Тренирую не только тело, но и дух! "),
                new TextSnippet("Чтобы... ", Color.White, characterDelay: 0.1f),
                new TextSnippet("взглянуть внутрь себя и узреть свои"),
                new TextSnippet("...", Color.White, characterDelay: 0.15f),
                new TextSnippet(" слабости.")
                ), portraits["suspicious"], ExitWhyHere, false);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstWhatNowPreDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...", Color.White, 0.04f, 3f, apparition: TextSnippet.AppearFadingFromTop)
                ), portraits["shocked"]);

        public static readonly TextboxInfo Lore_SecondWhatNowPreDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...Ха! Какой любопытный. Видимо, я слишком привык к молчанию ", Color.White),
                new TextSnippet("Сигнатия", new Color(12, 241, 176), 0.05f, 1.1f),
                new TextSnippet(".", Color.White)
                ), portraits["neutral"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_ThirdWhatNowPreDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Открою больше, если "),
                new TextSnippet("победишь меня в поединке! ", new Color(255, 209, 68)),
                new TextSnippet("—", Color.White, characterDelay: 0.5f),
                new TextSnippet(" Покажи свою силу, свою доблесть. Докажи, что достоин знать мою историю!")
                ), portraits["suspicious"], ExitWhatNowPreDefeat, false);
        #endregion

        #region Post-defeat
        public static readonly TextboxInfo Lore_FirstWhatReallyHappened = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet(" ", Color.White, characterDelay: 2f),
                new TextSnippet("...", Color.White, 0.2f, 1.3f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("Я знаю, что ", Color.White, 0.1f, 1.3f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("королевство", SeaKingdomForcesColor, 0.1f, 1.3f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" пало. ", Color.White, 0.1f, 1.3f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet("...Даже бежав, я чувствовал, как вода кипит от пламени.", Color.White, characterDelay: 0.04f)
                ), portraits["hollow"]);

        public static readonly TextboxInfo Lore_SecondWhatReallyHappened = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("А эти ", Color.White, characterDelay: 0.05f),
                new TextSnippet("захватчики", UndeadForcesColor, 0.1f, 1.1f),
                new TextSnippet("!.. ", Color.White, characterDelay: 0.05f),
                new TextSnippet("Они были не живыми! Это были НАШИ павшие —", Color.White),
                new TextSnippet(" не только воины, но все!", Color.White),
                new TextSnippet(" Семьи, друзья, дети... мои...", Color.White, characterDelay: 0.05f, displacement: TextSnippet.SmallRandomDisplacement)
                ), portraits["enraged"]);

        public static readonly TextboxInfo Lore_ThirdWhatReallyHappened = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...", Color.White, 1.2f, 1.6f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" О, ", Color.White, characterDelay: 0.04f),
                new TextSnippet("Король Амидиас", SeaKingdomForcesColor, 0.04f, 1.1f),
                new TextSnippet("...", Color.White, characterDelay: 0.6f)
                ), portraits["hollow"]);

        public static readonly TextboxInfo Lore_FourthWhatReallyHappened = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet(" Если б я не бежал! Мои кости до сих пор горят от стыда! ", Color.White),
                new TextSnippet("Стыд и есть то, приковало меня к этой проклятой пещере!", Color.White, displacement: TextSnippet.SmallRandomDisplacement)
                ), portraits["enraged"], ExitWhatReallyHappened);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstWhatHappenedToYou = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Я бежал сюда, под толщу океана. Но ", Color.White, characterDelay: 0.04f),
                new TextSnippet("мертвецы", UndeadForcesColor, 0.1f, 1.1f),
                 new TextSnippet("несли пламя, что выжгло воду... А я иссох, как рыба на солнце.", Color.White, characterDelay: 0.04f)
                ), portraits["hollow"]);

        public static readonly TextboxInfo Lore_SecondWhatHappenedToYou = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Наш вид может жить без воды недолго... Разрушения заточили меня здесь навеки.")
                ), portraits["neutral"], ExitWhatHappenedToYou);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstHowDidYouKeepYourSanity = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Безумие не обошло меня. ", Color.White, characterDelay: 0.06f),
                new TextSnippet("Бывали моменты, когда я видел сны, вновь переживая воспоминания о той битве. Те, кто пал, защищая наш народ, вспыхивали пламенем, присоединясь к ", Color.White, characterDelay: 0.04f),
                new TextSnippet("рядам нежити", UndeadForcesColor, characterDelay: 0.04f),
                 new TextSnippet("...", Color.White, characterDelay: 0.04f)
                ), portraits["solemn"]);

        
        public static readonly TextboxInfo Lore_SecondHowDidYouKeepYourSanity = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Н-но в этих кошмарах не мог понять — против кого? На чьей стороне? ", Color.White, characterDelay: 0.04f),
                new TextSnippet("Но, пробуждаясь здесь... я вспоминаю: я бежал. И умер в одиночестве.", Color.White, characterDelay: 0.04f)
                ), portraits["solemn"], ExitHowDidYouKeepYourSanity, false);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Не знаю"),
                new TextSnippet("...", Color.White, characterDelay: 0.15f),
                new TextSnippet(" останусь здесь"),
                new TextSnippet("...", Color.White, characterDelay: 0.15f),
                new TextSnippet(" выбора у меня всё равно нет.")
                ), portraits["neutral"]);

        public static readonly TextboxInfo Lore_SecondWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Шум прибоя сменился шепотом песка и ничто не в силах вернуть его"),
                new TextSnippet("...", Color.White, characterDelay: 0.4f),
                new TextSnippet(" Время ушло, а я — его пережиток.", Color.White, characterDelay: 0.025f, displacement: TextSnippet.SmallRandomDisplacement)
                ), portraits["suspicious"]);

        public static readonly TextboxInfo Lore_ThirdWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("...", Color.White, 0.4f, 3f, apparition: TextSnippet.AppearFadingFromTop)
                ), portraits["curious"]);

        public static readonly TextboxInfo Lore_FourthWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Прости за мрачность! Не хочу, чтобы мои печали отпугнули тебя.")
                ), portraits["pog"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_FifthWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Ты", new Color(175, 220, 20), 0.06f, 1.5f, displacement: TextSnippet.RandomDisplacement),
                new TextSnippet("! Иди вперёд — за меня!", Color.White, 0.06f, 1.5f, displacement: TextSnippet.RandomDisplacement)
                ), portraits["starstruckhands"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_SixthWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Мне утешительно осознавать, что ты продолжишь расти и меняться.")
                ), portraits["laughing"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo Lore_SeventhWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Смотри на мир широко, а мои печали — забудь, как забыл их я!")
                ), portraits["laughing"], GiveKeepsakeToPlayer, false);

        public static readonly TextboxInfo Lore_EighthWhatNowPostDefeat = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Вот, прими этот "),
                new TextSnippet("королевский медальон", SeaKingdomForcesColor),
                new TextSnippet(" как знак нашей связи. Немного, но я очень надеюсь, что ты будешь навещать старую рыбину!")
                ), portraits["surprised"], ExitWhatNowPostDefeat, false);

        //------------------------------------------------------------------
        public static readonly TextboxInfo Lore_FirstWhatsUp = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Если не считать твоих визитов — здесь всё так же скучно.")
                ), portraits["neutral"]);

        public static readonly TextboxInfo Lore_SecondWhatsUp = new(
            new(480f, SirNautilus.RegularSpeech, new TextSnippet("Скажи", Color.White),
                new TextSnippet("...", Color.White, characterDelay: 0.2f),
                new TextSnippet(" встречал ли ты других моих сородичей? Хотел бы знать, остались ли они...")
                ), portraits["curious"]);
        #endregion

        #endregion

        #region Other textboxes
        public static readonly TextboxInfo FightStart_JustificationOnFirstInteraction = new(
            new(480f, SirNautilus.RegularSpeech,
                new TextSnippet("А!", Color.White, 0.025f, 1.1f, displacement: TextSnippet.SmallRandomDisplacement),
                new TextSnippet(" Может мои косточки и давно не дрались, но я не терял форму!", Color.White),
                new TextSnippet(" ", Color.White, 0.6f),
                new TextSnippet("Эн гард!", new Color(255, 209, 68), 0.04f, 1.3f, null, TextSnippet.AppearFadingFromTop, TextSnippet.RandomDisplacement)
                ), portraits["laughing"], SummonNautilus, true, QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        public static readonly TextboxInfo UncannyTextbox = new(
           new(480f, SirNautilus.RegularSpeech,
               new TextSnippet("...", Color.White, 0.2f, 1.8f, null, TextSnippet.AppearFadingFromTop),
               new TextSnippet(" подождите", Color.White, 0.03f, 0.9f, null, TextSnippet.AppearFadingFromTop, TextSnippet.SmallRandomDisplacement),
               new TextSnippet(" ", Color.White, 0.36f, 1f, null),
               new TextSnippet("было ", Color.White, 0.03f, 1f, null, TextSnippet.AppearFadingFromTop, TextSnippet.SmallRandomDisplacement),
               new TextSnippet("СКОЛЬКО-СКОЛЬКО РАЗРАБОТЧИКОВ???", Color.White, 0.08f, 2f, null, TextSnippet.AppearFadingFromTop, TextSnippet.SmallRandomDisplacement)
               ), portraits["uncanny"], QuadrilateralBoxWithPortraitUI.ShakyPortrait);

        #endregion

        #endregion
        
        #region Buttons
        public static readonly ButtonInfo StartFightButton = new(new TextSnippet("Вызов", Color.White, displacement: TextSnippet.RandomDisplacement), InitiateFight, false);
        public static readonly ButtonInfo LoreButton = new(new TextSnippet("Кто ты?", Color.White), OpenLoreQuestions, false);

        public static readonly ButtonInfo GoToWhyHereButton = new(new TextSnippet("Почему здесь?", Color.White), AskWhyHere, false);
        public static readonly ButtonInfo GoToWhatAreYouDoingButton = new(new TextSnippet("Чем занимаешься?", Color.White), AskWhatAreYouDoing, false);

        public static readonly ButtonInfo GoToWhatNowFromWhyHereButton = new(new TextSnippet("Что дальше?", Color.White), AskWhatNowFromWhyHere, false);
        public static readonly ButtonInfo GoToWhatNowFromWhatchaDoinButton = new(new TextSnippet("Что дальше?", Color.White), AskWhatNowFromWhatAreYouDoing, false);

        public static readonly ButtonInfo GoToWhatHappenedToYouButton = new(new TextSnippet("Что с тобой случилось?", Color.White), AskWhatHappenedToYou, false);
        public static readonly ButtonInfo GoToHowDidYouKeepYourSanityButton = new(new TextSnippet("Как ты остался в здравом уме?", Color.White), AskHowDidYouKeepYourSanity, false);

        public static readonly ButtonInfo GoToWhatNowFromWhatHappenedToYouButton = new(new TextSnippet("Что дальше?", Color.White), AskWhatNowFromWhatHappenedToYou, false);
        public static readonly ButtonInfo GoToWhatNowFromHowDidYouKeepYourSanityButton = new(new TextSnippet("Что дальше?", Color.White), AskWhatNowFromHowDidYouKeepYourSanity, false);

        public static readonly ButtonInfo GoToWhatsUpFromWhatHappenedToYouButton = new(new TextSnippet("Как дела?", Color.White), AskWhatsUpFromWhatHappenedToYou, false);
        public static readonly ButtonInfo GoToWhatsUpFromHowDidYouKeepYourSanityButton = new(new TextSnippet("Как дела?", Color.White), AskWhatsUpFromHowDidYouKeepYourSanity, false);
        #endregion
