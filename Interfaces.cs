namespace Escape
{
    //Interface for Cartography
    interface ICartography
    {
        void UserName();
        void FirstRoom();
        void BlueRoom();
        string TreeRoom();
    }

    //Interface fights
    interface IFights
    {

        string FightGuards(string path);
        string DetermineFightOutcome(string userAttack, string guardAttack);
    }

    // Interface for Drawing
    interface IDrawing
    {
        void Cart();
        void OldMan();
        void Tree();
        void Guards();
        void Arms();
    }

    //Interface for Tips
    interface ITips
    {
        void FirstRoomTips(string tip);
    }
}
