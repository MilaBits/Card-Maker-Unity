using System;

[Flags]
public enum Role {
        None = 0,
        Pilot = 1,
        ScienceOfficer = 2,
        Gunner = 4,
        Captain = 8,
        Mage = 16,
        Engineer = 32
    }
