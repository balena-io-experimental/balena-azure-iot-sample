
set(AGENT_TIME_SRC ../../adapters/agenttime.c)
add_executable(agenttime_unittests agenttime_unittests.cpp main.c ${AGENT_TIME_SRC})


target_include_directories(agenttime_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (agenttime_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock)
