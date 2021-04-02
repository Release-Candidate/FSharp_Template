#!/bin/bash

LINE_NUMS=$(grep '##' CHANGELOG.md -n| head -2|cut -f1 -d":"|paste -s -d' ')

LINE_NUM_ARRAY=(${LINE_NUMS})

if [ "${#LINE_NUM_ARRAY[@]}" -lt "1" ]
then
    echo ""
elif [ "${#LINE_NUM_ARRAY[@]}" -lt "2" ]
then
    tail +${LINE_NUM_ARRAY[0]} CHANGELOG.md
else
    head -$((${LINE_NUM_ARRAY[1]} - 1)) CHANGELOG.md | tail +${LINE_NUM_ARRAY[0]}
fi

