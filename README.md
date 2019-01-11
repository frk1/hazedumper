# hazedumper

🚀 Up to date offset and dumper-config for Counter-Strike: Global Offensive. For more informations visit the [release page on UnKnoWnCheaTs](https://www.unknowncheats.me/forum/counterstrike-global-offensive/169351-haze-dumper-json-config-based-offset-dumper.html).

## Local Player
Since in the past the signature for the LocalPlayer was broken a few times and/or pointed to something wrong, I want to offer you an alternative.
All required offsets are already in the repo, why 99% of people don't use them is questionable - or they are just too incompetent and complain
that nothing works, but they can't find a single signature themselves. However, pretty much every hack uses the entity list (`dwEntityList`)
and also ClientState (`dwClientState`). All you need is a third offset which is located in ClientState, called `dwClientState_GetLocalPlayer`.

```C++
const auto client_state = read_memory<std::uint32_t>( engine_image->base + hazedumper::signatures::dwClientState );
if( client_state ) {
    const auto local_player = get_client_entity( 
        read_memory<std::int32_t>( client_state + hazedumper::signatures::dwClientState_GetLocalPlayer )
    );

    if( local_player ) {
        printf(
            "[+] Found local player: 0x%X, health: %d\n",
            local_player,
            read_memory<std::int32_t>( local_player + hazedumper::netvars::m_iHealth )
        );
    }
}
```

## Informations

- ⚠️ Since we are both working and living in germany, we can't see 24/7 if there was an update and then push it. We make every effort to ensure that this happens as soon as possible.
- 🔫 The repository always refers to the latest version of the [steam store](http://store.steampowered.com/app/730/CounterStrike_Global_Offensive).
- ⚠️ We are not liable for VAC bans in case of incorrect use.

## Credits:

- [VALVe](https://github.com/ValveSoftware) for their [2013 edition of the Source SDK](https://github.com/ValveSoftware/source-sdk-2013) and also [the leaked version from 2007](https://github.com/VSES/SourceEngine2007)
- [frk](https://www.unknowncheats.me/forum/members/1067779.html)
- [ReactiioN](https://www.unknowncheats.me/forum/members/264622.html)
