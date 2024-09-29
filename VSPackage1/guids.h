﻿// guids.h: definitions of GUIDs/IIDs/CLSIDs used in this VsPackage

/*
Do not use #pragma once, as this file needs to be included twice.  Once to declare the externs
for the GUIDs, and again right after including initguid.h to actually define the GUIDs.
*/



// package guid
// { 8a1ed544-f4e3-4e6d-9c09-fbe023caffa9 }
#define guidVSPackage1Pkg { 0x8A1ED544, 0xF4E3, 0x4E6D, { 0x9C, 0x9, 0xFB, 0xE0, 0x23, 0xCA, 0xFF, 0xA9 } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_VSPackage1,
0x8A1ED544, 0xF4E3, 0x4E6D, 0x9C, 0x9, 0xFB, 0xE0, 0x23, 0xCA, 0xFF, 0xA9 );
#endif

// Command set guid for our commands (used with IOleCommandTarget)
// { 9af691c0-4c09-4044-8844-794a66b816bc }
#define guidVSPackage1CmdSet { 0x9AF691C0, 0x4C09, 0x4044, { 0x88, 0x44, 0x79, 0x4A, 0x66, 0xB8, 0x16, 0xBC } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_VSPackage1CmdSet, 
0x9AF691C0, 0x4C09, 0x4044, 0x88, 0x44, 0x79, 0x4A, 0x66, 0xB8, 0x16, 0xBC );
#endif

//Guid for the image list referenced in the VSCT file
// { faf4772f-f684-4584-8be5-5fbf35107203 }
#define guidImages { 0xFAF4772F, 0xF684, 0x4584, { 0x8B, 0xE5, 0x5F, 0xBF, 0x35, 0x10, 0x72, 0x3 } }
#ifdef DEFINE_GUID
DEFINE_GUID(CLSID_Images, 
0xFAF4772F, 0xF684, 0x4584, 0x8B, 0xE5, 0x5F, 0xBF, 0x35, 0x10, 0x72, 0x3 );
#endif


