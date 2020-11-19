using UnityEngine;

public class SaveManager
{
    #region Singleton
    private static SaveManager instance;
    public static SaveManager getInstance
    {
        get
        {
            if(instance==null)
            {
                instance = new SaveManager();
                return instance;
            }
            else
                return instance;
        }
    }
    #endregion

    PlayerData _playerData;
    //more Classes and more process can be.

    public void SaveGame(Player player)
    {
        _playerData = new PlayerData();
        _playerData.health = player.getHealth();
        _playerData.playerID = player.getPlayerID();

        SerializePlayerData(_playerData);
    }

    private void SerializePlayerData(PlayerData playerData)
    {
        // Saving Process
    }
}
