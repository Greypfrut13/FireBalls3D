using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSequence 
{
    private readonly IReadOnlyList<IMovementSequenceTerm> _terms;
    private readonly CoroutineExecutor _coroutineExecutor;

    private int _currentTermIndex;
    private Coroutine _executableSequence;

    public MovementSequence(IReadOnlyList<IMovementSequenceTerm> terms, CoroutineExecutor coroutineExecutor)
    {
        if(terms is null || terms.Count == 0)
            throw new ArgumentException(nameof(terms));

        _terms = terms;
        _coroutineExecutor = coroutineExecutor;
        _currentTermIndex = 0;
    }

    public void StartProcessing()
    {
        _executableSequence = _coroutineExecutor.Start(ChangeBetwenStates());
    }

    public void Stop()
    {
        _coroutineExecutor.Stop(_executableSequence);
    }

    private IEnumerator ChangeBetwenStates()
    {
        while(true)
        {
            IEnumerator termCoroutine = _terms[_currentTermIndex].GetSequenceTermCoroutine();

            yield return _coroutineExecutor.Start(termCoroutine);

            _currentTermIndex = GetNextTermIndex(_currentTermIndex);
        }
    }

    private int GetNextTermIndex(int currentIndex)
    {
        return (currentIndex + 1) % _terms.Count;
    } 
}
