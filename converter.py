#!/usr/bin/python
import json

print( '#-----------------------------------#\n'
       '#-- haze-dumper offset converter  --#\n'
       '#--               by ReactiioN    --#\n'
       '#--                               --#\n'
       '#-- Options:                      --#\n'
       '#--    1: convert to visual basic --#\n'
       '#--    2: convert to C#           --#\n'
       '#-----------------------------------#\n' )

converter_type = 0
while 1:
    userInput = input('Convert to (1: Visual Basic, 2: C#): ')
    if userInput == 1 or userInput == 2:
        converter_type = userInput
        break

outputFile = 'csgo.cs'
if converter_type == 1:
    outputFile = 'csgo.vb'

def tabToSpaces(numTabs, shift=4):
    s = ''
    for i in range(0,numTabs):
        for x in range(0,shift):
            s += ' '
    return s

singleIdent = tabToSpaces(1)
doubleIdent = tabToSpaces(2)

def offsetToVB(name, offset):
    return 'Public Const {} as Integer = &{}'.format(name, hex(offset).upper().replace('0X', 'H'))

def offsetToCSharp(name, offset):
    return 'public const Int32 {} = {};'.format(name, hex(offset).upper().replace('0X', '0x'))

def convertToVB(data):
    s = 'Namespace hazedumper\n{}Namespace signatures'.format(singleIdent)
    for key in data['signatures']:
        s += '\n{}{}'.format(doubleIdent, offsetToVB(key, data['signatures'][key]))
    s += '\n{}End Namespace\n\n{}Namespace netvars'.format(singleIdent, singleIdent)
    for key in data['netvars']:
        s += '\n{}{}'.format(doubleIdent, offsetToVB(key, data['netvars'][key]))
    s += '\n{}End Namespace\nEnd Namespace\n'.format(singleIdent)
    return s

def convertToCSharp(data):
    s = 'using System;\n\nnamespace hazedumper\n{}\n{}namespace signatures\n{}{}'.format('{',singleIdent, singleIdent, '{')    
    for key in data['signatures']:
        s += '\n{}{}'.format(doubleIdent, offsetToCSharp(key, data['signatures'][key]))
    s += '\n{}{}\n\n{}namespace netvars\n{}{}'.format(singleIdent, '}', singleIdent, singleIdent, '{')
    for key in data['netvars']:
        s += '\n{}{}'.format(doubleIdent, offsetToCSharp(key, data['netvars'][key]))
    s += '\n{}{}\n{}'.format(singleIdent, '}', '}')
    return s


with open( 'csgo.min.json' ) as data_file:
    data = json.load( data_file )

with open( outputFile, 'w+' ) as convertedFile:
    if converter_type == 1:
        convertedFile.write(convertToVB(data))
    else:
        convertedFile.write(convertToCSharp(data))
    convertedFile.close()
