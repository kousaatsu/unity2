using System.Collections.Generic;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace AttackSystem
{
    public class AttackStrategySetter : MonoBehaviour
    {
        [SerializeField] private List<Button> _buttons;
        [SerializeField] private ColorBlock _chosenButtonColors;
        private AttackPerformer _attackPerformer;
        private Button _chosenButton;
        private ColorBlock _defaultButtonColors;

        public void Construct(AttackPerformer attackPerformer)
        {
            _attackPerformer = attackPerformer;
        }

        private void Start()
        {
            _buttons[0].onClick.AddListener(() => SetStrategy(new Swing1(), _buttons[0]));
            _buttons[1].onClick.AddListener(() => SetStrategy(new Swing2(), _buttons[1]));
            _buttons[2].onClick.AddListener(() => SetStrategy(new Swing3(), _buttons[2]));
        }

        private void SetStrategy(IAttackStrategy attackStrategy, Button button)
        {
            _attackPerformer.SetStrategy(attackStrategy);
            if (_chosenButton != null)
                _chosenButton.colors = _defaultButtonColors;
            _defaultButtonColors = button.colors;
            button.colors = _chosenButtonColors;
            _chosenButton = button;
        }
    }
}
