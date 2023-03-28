using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class TowerComponentLinking : MonoBehaviour
{
    [SerializeField] private Transform _towerRoot;
    [SerializeField] private TowerGenerator _generator;
    [SerializeField] private RestoreProjectilePoolTrigger _projectileHitTrigger;
    [SerializeField] private TowerSegmentsLeftText _segmentsLeftText; 

    private TowerDisassembling _disassembling;
    private Tower _tower;

    private IReadOnlyReactiveProperty<int> _towerSegmentCount = new FakeReactiveProperty<int>();

    [ContextMenu(nameof(Prepare))]
    public async Task Prepare()
    {
        _tower = await _generator.Generate();

        _disassembling = new TowerDisassembling(_tower, _towerRoot);
        _projectileHitTrigger.ProjectileReturned += _disassembling.TryRemoveBottom;

        _towerSegmentCount = _tower.SegmentCount;

        _towerSegmentCount.Subscribe(_segmentsLeftText.UpdateTextValue);
    }

    private void OnDisable()
    {
        if(_disassembling != null)
            _projectileHitTrigger.ProjectileReturned -= _disassembling.TryRemoveBottom;

        _towerSegmentCount.Unsubscribe(_segmentsLeftText.UpdateTextValue);
    }
}
