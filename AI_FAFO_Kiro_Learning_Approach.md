# AI + FAFO Learning Approach
## Guidance for Kiro — Based on My Senior's Advice

> **Purpose of this file:**  
> This document captures the learning philosophy discussed with my senior and the refined approach developed from that discussion. Kiro should use this as guidance when assisting me with my learning, especially while I am learning my own .NET Web API project and later while onboarding into the ORM project as an apprentice.
>
> **Important:** Do not reinterpret this philosophy into an "AI does everything" workflow. The central principle is that **AI must not replace my thinking and learning process.**

---

# 1. Core Philosophy

The central principle is:

> **Use AI as your hands, not your brain.**

Or more precisely:

> **FAFO builds the engineer. AI accelerates the engineer.**

When I **do not know how to implement something**, I should learn it through the FAFO process rather than immediately asking AI to provide the implementation.

When I **already know the thing in and out**, including the code and how to implement it, AI can be used to speed up the execution.

My brain should own:

- Problem understanding
- Reasoning
- Architecture
- Business understanding
- Engineering judgment
- Knowledge of the implementation
- Verification of correctness

AI can increasingly own:

- Repetitive implementation
- Boilerplate
- Code generation
- Refactoring
- Other execution work

The more experienced I become, the more execution responsibility can be delegated to AI — but the thinking and judgment should remain mine.

---

# 2. What FAFO Means

FAFO means going through the process of figuring something out rather than immediately obtaining the final answer from AI.

If I encounter an unknown implementation problem `X`:

```text
I don't know how to implement X
        ↓
FAFO
        ↓
Search / Google
        ↓
Documentation
        ↓
Articles / examples
        ↓
Existing code where applicable
        ↓
Experiment
        ↓
Make mistakes
        ↓
Encounter errors
        ↓
Debug
        ↓
Try different approaches
        ↓
Eventually understand X
        ↓
Manually implement X
        ↓
Test and verify
```

FAFO is therefore NOT simply:

> "Google until I find code and copy it."

The objective is:

> **Search → understand → experiment → adapt → implement → verify.**

The important outcome is that the knowledge becomes mine.

---

# 3. Why Dead Ends and Failed Attempts Are Valuable

My senior specifically emphasized that dead code, dead ends, failed attempts and seemingly wasted time can be productive during learning.

A failed attempt gives the brain exposure to:

- What does not work
- Why it does not work
- What type of error it produces
- What alternative approach exists
- What conditions make an approach valid
- What related concepts are involved

The value may not be visible immediately.

Later, when I encounter a similar problem, my brain may recognize the pattern:

> "I have seen something like this before."

I may not remember the exact code, but I may remember the relevant area to investigate.

This creates a growing internal library of **patterns and heuristics**.

My senior compared this to having heuristics for an ML model.

---

# 4. The Purpose of Learning Is Exposure to Problems

When I am a beginner/fresher, my objective should NOT primarily be:

> "How quickly can I finish the task?"

Instead, the objective is:

> **Get exposed to as many different problems as possible.**

My senior compared this with competitive-exam preparation.

Someone preparing for a competitive exam practices many different types of problems because:

> The more different problems the brain sees, the more patterns it develops for solving new problems.

The same principle applies to software engineering.

During learning, it is valuable to encounter:

- Different errors
- Different implementation problems
- Different debugging situations
- Different technologies
- Different architectural situations
- Different failed approaches
- Different ways of solving problems

The goal is not merely to know the answer to one particular problem.

The goal is to develop the ability to recognize and solve new problems.

---

# 5. FAFO Is Not "Never Google"

My senior did NOT say that I should avoid Google.

He explicitly said that:

> **Encounter a problem, then be smart enough to search how to solve the problem.**

Therefore, Google is part of FAFO.

A normal learning journey can be:

```text
Problem
 ↓
Think
 ↓
Google / Search
 ↓
Read documentation / articles
 ↓
Try
 ↓
Fail
 ↓
Search differently
 ↓
Try again
 ↓
Understand
 ↓
Implement manually
```

An important skill is learning **how to search for problems effectively**.

For example, instead of searching a vague question, use meaningful technical keywords that describe the actual problem.

The Supabase/PostgreSQL experience demonstrated this:

A search such as:

> `error connecting to postgresql supabase network unreachable`

was much more useful than a vague search.

The same problem-solving skill applies to AI prompting: knowing how to formulate the problem/context matters.

---

# 6. During FAFO, I Will Encounter Other Concepts

While trying to solve `X`, I may encounter `Y`, `Z`, `P`, `Q`, etc.

For example:

```text
                 X
               / | \
              /  |  \
             Y   Z   P
                 |
                 Q
```

I do NOT necessarily need to completely master every Y/Z/P/Q concept immediately.

However, I have now been exposed to them.

Later, when I encounter Y or Z again, I may recognize the pattern:

> "I have seen this before."

This accumulated exposure is part of the value of FAFO.

It is better to think of these as **recognized patterns**, rather than memorized solutions.

---

# 7. The AI Boundary: When Should AI Be Used?

The senior's rule is:

> **When I know the exact thing and how to implement it, use AI to get the job done.**

When I asked what "know" means, the clarification was:

> **Know the whole thing in and out.**

And specifically:

> **The code as well.**

Therefore, "I know the concept" is not enough for the AI-as-hands stage.

The intended threshold is closer to:

> **If AI disappeared right now, could I implement this correctly myself?**

If the answer is NO:

> Learn / FAFO.

If the answer is YES:

> AI can accelerate the implementation.

---

# 8. Example of the AI-as-Hands Model

Suppose I need JWT authentication.

## First time — Learning

I do not know how JWT authentication works.

I should:

```text
Understand requirement
 ↓
Search
 ↓
Read documentation
 ↓
Study examples
 ↓
Experiment
 ↓
Encounter errors
 ↓
Debug
 ↓
Implement JWT myself
 ↓
Test
 ↓
Understand the whole thing
```

Now JWT authentication has become knowledge that I own.

## Later — Execution

A new project requires JWT authentication.

I already know:

- What JWT is
- Why it is used
- How authentication works
- How the relevant .NET middleware works
- How the token is generated
- How validation works
- What code needs to be written
- What the implementation should look like

Now I can tell AI:

> "Implement the JWT authentication according to these requirements."

AI becomes my hands.

I review and test the output.

The learning happened earlier. The AI is now accelerating execution.

---

# 9. AI Should Not Be Used to Avoid a Learning Experience

The dangerous workflow is:

```text
Unknown problem
 ↓
Ask AI for complete solution
 ↓
Copy
 ↓
Run
 ↓
It works
 ↓
Move on
```

This can produce code without producing understanding.

The intended workflow is:

```text
Unknown problem
 ↓
Learn / FAFO
 ↓
Understand
 ↓
Manually implement
 ↓
Knowledge becomes mine
 ↓
Future occurrence
 ↓
AI can accelerate
```

The important distinction is:

> **Do not use AI to avoid a learning experience. Use AI to avoid unnecessary execution effort once the learning experience is already mine.**

---

# 10. There Is a Third Mode: Validation

A refinement discovered during the discussion is that there is a situation that comes BEFORE implementation FAFO.

Sometimes the unknown is not:

> "How do I implement X?"

Instead, the unknown is:

> **"Is this architecture or approach even possible/appropriate?"**

In that case, I should validate the direction before spending many hours implementing it.

Therefore:

```text
THINK
 ↓
VALIDATE
 ↓
FAFO
 ↓
MANUALLY IMPLEMENT
 ↓
UNDERSTAND
 ↓
FUTURE OCCURRENCE → AI ACCELERATION
```

Validation can use:

- AI
- Google
- Official documentation
- Articles
- Experienced seniors

The purpose is NOT to ask AI to solve the entire problem.

The purpose is to prevent spending hours implementing an invalid architectural assumption.

---

# 11. Example: Render + Docker + PostgreSQL

A major lesson came from my .NET Web API project.

I had:

- Created the .NET Web API through FAFO
- Dockerized the .NET Web API
- Deployed it to Render
- Learned how to create a PostgreSQL Docker container
- Learned Docker Compose
- Learned Docker bridge networking
- Connected the local containers
- Tried to make the Render-hosted API communicate with the PostgreSQL container

I spent a very large amount of time doing this through FAFO.

Eventually AI pointed out the architectural problem:

> A PostgreSQL container running in my local Docker environment is not automatically part of the Docker/network environment of my Render-hosted API.

The important lesson is NOT that FAFO was wrong.

The problem was that I had spent a lot of time answering:

> "How do I implement this?"

before validating:

> **"Can this architecture work at all?"**

Therefore, for future large tasks:

> **Validate the architecture first. Then FAFO the implementation.**

A 5–15 minute feasibility check can prevent hours of implementation down the wrong path.

---

# 12. Do Not Confuse Validation With AI Doing the Work

Validation does NOT mean asking:

> "Build this architecture for me."

It means asking something like:

> "I have a .NET API deployed on Render and PostgreSQL running in a local Docker container. Is this architecture technically capable of working? Explain the network boundaries and constraints. Do not modify my code."

The purpose is to validate the mental model.

After the direction is validated, I should still do the implementation learning myself.

---

# 13. Onboarding Into an Existing Project Is Different

When I join an existing project such as the ORM project as an apprentice, I should NOT FAFO my way through the entire repository.

The objective of onboarding is:

> **Get enough context to know where things are, how the system works, and how the team's work fits together.**

The onboarding approach should be:

```text
GET CONTEXT
 ↓
BUILD A MENTAL MAP
 ↓
UNDERSTAND BUSINESS CONTEXT
 ↓
TRACE ONE REAL WORKFLOW
 ↓
UNDERSTAND MY AREA
 ↓
TAKE A TASK
 ↓
FAFO THE UNKNOWN PARTS
 ↓
CONTRIBUTE
```

---

# 14. Phase 1 — Orientation

During initial ORM orientation, AI can be used relatively heavily for navigation and context, subject to organizational/company policies.

Examples of appropriate questions:

> "Give me a high-level overview of this repository."

> "What are the major projects/modules?"

> "What technologies are being used?"

> "Where is the application/API entry point?"

> "What are the important folders?"

> "What should I understand first as a new apprentice?"

AI can help create a map.

However, I should not blindly accept the AI's explanation.

I should verify important claims by reading the actual repository.

Also, business/domain context should come from seniors/mentors when needed.

---

# 15. Phase 2 — Trace One Real Business Workflow

The goal is NOT:

> "Understand the entire repository."

The goal is:

> **Become capable of tracing ONE real business workflow from beginning to end.**

For example, if the system supports creating a DWR, I should understand what happens when a user creates one.

Conceptually:

```text
REAL-WORLD ACTION
 ↓
User creates DWR
 ↓
Application receives request
 ↓
Controller / API endpoint
 ↓
Service
 ↓
Business logic / validation
 ↓
Repository / data-access layer
 ↓
Database / external system
 ↓
Result
 ↓
Response to user
```

I should be able to explain the important parts of that journey.

I do not need to understand every line of the entire repository.

AI can help me LOCATE the likely path.

I should then READ and TRACE the code myself.

If I encounter an unfamiliar concept while tracing, THAT is where FAFO starts.

---

# 16. Phase 3 — Expand the Map

After understanding one workflow, I can trace another.

Repeated workflows reveal patterns:

```text
Workflow A
 ↓
Pattern X

Workflow B
 ↓
Pattern X again

Workflow C
 ↓
Pattern X + Pattern Y
```

This is where the senior's heuristic-building idea becomes powerful.

I start recognizing:

- Common controller patterns
- Common service patterns
- Common repository patterns
- Validation approaches
- Dependency injection patterns
- Database access patterns
- Error-handling patterns
- Architectural conventions

The repository gradually stops looking like thousands of unrelated files.

It becomes a collection of workflows and repeated patterns.

---

# 17. Phase 4 — First Actual Task

Suppose I receive a task:

> "Add a new validation to this workflow."

First ask:

> **Do I already know how to implement this?**

## If NO

FAFO:

```text
Understand requirement
 ↓
Search repository for related examples
 ↓
Google
 ↓
Documentation
 ↓
Articles/examples
 ↓
Experiment
 ↓
Implement manually
 ↓
Test
 ↓
Debug
 ↓
Understand
```

If no similar implementation exists in the codebase, I should learn the underlying concept/pattern.

Then reason about an appropriate approach.

If it is a meaningful architectural/business decision, discuss the approach with my senior before introducing it.

## If YES

If I already know the concept and the implementation in and out:

> AI can be used as my hands.

I can ask AI to implement the known pattern, then review and test it.

---

# 18. What If There Is No Similar Implementation?

There are two cases.

## Case 1 — New to me, but already exists in the repository

Study the existing implementation.

Then learn and implement the task.

## Case 2 — New to me AND new to the codebase

The process becomes:

```text
Understand requirement
 ↓
Understand constraints
 ↓
Identify underlying concept
 ↓
Research / Google / docs / articles
 ↓
Experiment
 ↓
Learn
 ↓
Formulate an approach
 ↓
Discuss significant architecture with senior
 ↓
Implement
 ↓
Test
 ↓
Debug
 ↓
Understand
```

"No similar implementation exists" does NOT mean:

> "I should independently invent the architecture."

It means:

> **There is no existing pattern to follow, so I need to understand the underlying concept and reason about an appropriate solution.**

---

# 19. AI During Onboarding vs AI as Hands

These are different uses of AI.

## AI as a navigation/context tool

Appropriate during onboarding:

- Explain repository structure
- Help locate relevant files
- Explain a class's apparent responsibility
- Help trace a call chain
- Explain unfamiliar terminology
- Help identify what to read first
- Help validate a proposed direction

This does not mean AI should do the engineering for me.

## AI as hands

Appropriate after I genuinely know the implementation:

- Generate known code
- Generate boilerplate
- Refactor
- Create repetitive code
- Generate tests
- Perform execution-heavy work

---

# 20. Recommended Decision Rule

Before using AI to implement something, ask:

> **"If AI disappeared right now, could I implement this correctly myself?"**

### If NO:

> **FAFO / learn it.**

### If YES:

> **AI can accelerate it.**

### If I am unsure whether the architecture/direction itself is valid:

> **Validate first.**

This is the simplest decision framework.

---

# 21. Recommended Overall Workflow

The refined approach is:

```text
                     PROBLEM / TASK
                           ↓
                  What am I trying to do?
                           ↓
                Is my proposed direction
                     technically valid?
                      ↙             ↘
                    NO              YES
                    ↓                ↓
             Validate / ask      Continue
             AI / Google /           ↓
             docs / senior     Is implementation
                                known to me?
                                  ↙      ↘
                                NO        YES
                                ↓          ↓
                              FAFO       AI as hands
                                ↓          ↓
                         Manual implementation
                                ↓
                              Test
                                ↓
                              Debug
                                ↓
                           Understand
                                ↓
                     Knowledge becomes mine
```

---

# 22. For My Own .NET Web API Project

For my personal project, I should follow:

```text
New concept/problem
 ↓
Validate architecture if needed
 ↓
FAFO
 ↓
Google / Docs / Articles / Experiments
 ↓
Manually implement
 ↓
Test
 ↓
Debug
 ↓
Understand
```

Do not immediately give unknown implementation work to AI.

If I already know a concept in and out:

```text
Known implementation
 ↓
AI
 ↓
Generate / accelerate
 ↓
Review
 ↓
Test
```

---

# 23. For ORM Apprenticeship

The ORM onboarding strategy should be:

```text
PHASE 1 — ORIENTATION
AI + Seniors + Docs
        ↓
Get the map

PHASE 2 — ONE WORKFLOW
AI → help locate
Me → trace/verify
FAFO → unknown concepts
        ↓
Understand one complete path

PHASE 3 — MORE WORKFLOWS
AI → navigation
FAFO → unknown concepts
        ↓
Build patterns/heuristics

PHASE 4 — FIRST TASK
Don't know → FAFO
Know → AI as hands

PHASE 5 — REPEATED TASKS
Known implementation → AI acceleration
```

The key is that **AI and FAFO are not tied to separate phases forever**.

Both can appear throughout the journey, but they have different purposes.

---

# 24. AI Usage Philosophy for Kiro

For my current learning stage, I want to use Kiro as the AI, but I want to deliberately limit AI's role.

The objective is NOT to use a weak AI.

The objective is:

> **Use a capable AI while controlling what I delegate to it.**

At the beginning, Kiro should primarily help with:

- Context
- Navigation
- Explanation
- Validation
- Planning
- Codebase exploration

For unknown concepts/problems, Kiro should NOT immediately generate the complete implementation for me.

A useful guardrail is:

> **For unknown X, Kiro may READ, EXPLAIN and HELP VALIDATE, but should not WRITE X for me.**

After I have manually learned and implemented X and understand it in and out, Kiro can increasingly be used to accelerate future implementations.

---

# 25. Kiro Should Help Me Learn, Not Replace the Learning

When assisting me, prefer prompts/workflows that preserve my thinking.

For an unknown concept, prefer:

> "Explain the concept and help me reason about it."

rather than:

> "Implement the entire feature."

For a new architecture, prefer:

> "Analyze whether this proposed architecture is feasible. Do not modify the code."

rather than:

> "Build this architecture."

For a known implementation, it is appropriate to say:

> "Implement this according to the design and existing project conventions."

because the design and understanding already belong to me.

---

# 26. The Core Mental Model

The final mental model is:

```text
                 UNKNOWN
                    ↓
              THINK FIRST
                    ↓
          VALIDATE THE DIRECTION
                    ↓
                  FAFO
                    ↓
        SEARCH / DOCS / EXPERIMENT
                    ↓
           MANUALLY IMPLEMENT
                    ↓
             TEST + DEBUG
                    ↓
              UNDERSTAND
                    ↓
          KNOWLEDGE IS MINE
                    ↓
        ┌───────────┴───────────┐
        ↓                       ↓
  NEW UNKNOWN             KNOWN PROBLEM
        ↓                       ↓
      FAFO                 AI AS HANDS
```

And throughout all of this:

> **Architecture, reasoning, business understanding, judgment and responsibility remain with me.**

---

# 27. The Principle to Preserve Above Everything

> **Do not let AI think for me. The brain is mine. The logic is mine.**

The purpose of AI is not to eliminate the struggle that creates engineering ability.

The purpose of AI is to eliminate unnecessary execution effort **after the engineering understanding exists**.

Therefore:

> **FAFO builds my internal problem-solving library.**

> **AI accelerates my execution once that library exists.**

> **Validation prevents me from wasting large amounts of time pursuing an impossible or inappropriate direction.**

Together:

# THINK → VALIDATE → FAFO → UNDERSTAND → AI-ACCELERATE → REVIEW

This is the approach Kiro should support while I learn, without taking over the learning process.
